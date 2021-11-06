using Database.Models;
using Database.Services;
using Design.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class AplyQuizForm : Form
    {
        private int _respondentId;
        private Quiz quiz;

        public AplyQuizForm(int respondentId, string respondentName, int quizId)
        {
            InitializeComponent();
            _respondentId = respondentId;
            SetControllers(quizId, respondentName);
        }

        private async void SetControllers(int id, string name)
        {
            var res = await QuizService.GetQuizById(id).ConfigureAwait(false);

            if (res.IsError)
            {
                MessageBox.Show(res.Msg,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                quiz = res.Data as Quiz;
            }

            Invoke(new Action(() =>
            {
                lbRespondentName.Text = name;
            }));            

            quiz.QuizQuestions.Select((question, index) => (question, index)).ToList().ForEach((item) =>
            {
                (var question, var index) = item;

                var txtQuestion = new TextBox
                {
                    Multiline = true,
                    Height = 30,
                    BorderStyle = BorderStyle.None,
                    Width = tableLayoutPanel1.Width - 20,
                    Name = "txtQuestion" + index,
                    Margin = new Padding(10),
                    Font = new Font("Calibri", 10, FontStyle.Bold)
                };

                var lbQuestion = new Label
                {
                    Name = "lbQuestion" + index,
                    Text = question.Question,
                    Font = new Font("Calibri", 10, FontStyle.Bold)
                };

                Invoke(new Action(() =>
                {
                    tableLayoutPanel1.Controls.Add(txtQuestion, 1, index);
                    tableLayoutPanel1.Controls.Add(lbQuestion, 1, index);

                    tableLayoutPanel1.RowStyles[0].SizeType = SizeType.AutoSize;
                }));                
            });
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            List<(int, string)> resposes = new();
            var count = quiz.QuizQuestions.Count; 

            for (int i = 1; i <= count; i++)
            {
                int index = (i * 2) - 1;
                int questionId = quiz.QuizQuestions
                    .Where(x => x.Question == tableLayoutPanel1.Controls[index].Text)
                    .Select(x => x.Id).FirstOrDefault();

                string res = tableLayoutPanel1.Controls[(i * 2) - 2].Text;

                resposes.Add((questionId, res));
            }

            var resRes  = await ResponseService.CreateResponses(_respondentId, resposes.ToArray());

            if (resRes.IsError)
            {
                MessageBox.Show(resRes.Msg,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                Utility.CloseOneOpenOne(this, new MainForm(quiz.UserId));
            }
        }
    }
}
