using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.Models;
using Database.Services;
using Design.Utilities;

namespace Design
{
    public partial class RespondentResponsesForm : Form
    {
        private readonly int _userId;
        public RespondentResponsesForm(int respondentId, string name, int userId)
        {
            InitializeComponent();
            _userId = userId;
            SetControllers(respondentId, name);
        }

        private async void SetControllers(int respondentId, string name)
        {
            var res = await ResponseService.GetResponseByRespondentId(respondentId);

            if (res.IsError)
            {
                MessageBox.Show(
                res.Msg,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                Invoke(new Action(() =>
                {
                    lbRespondentName.Text = name;
                    this.Text += name;
                }));

                (res.Data as List<QuestionResponse>).Select((question, index) => (question, index)).ToList().ForEach((item) =>
                {
                    (var question, var index) = item;

                    var lbQuestion = new Label
                    {
                        Name = "lbQuestion" + index,
                        Text = question.QuizQuestion.Question,
                        Font = new Font("Calibri", 10, FontStyle.Bold)
                    };

                    var lbResponse = new Label
                    {
                        Name = "lbResponse" + index,
                        Text = question.Response,
                        Margin = new Padding(10),
                        Font = new Font("Calibri", 10, FontStyle.Regular)
                    };

                    Invoke(new Action(() =>
                    {
                        table.Controls.Add(lbResponse, 1, index);
                        table.Controls.Add(lbQuestion, 1, index);

                        table.RowStyles[0].SizeType = SizeType.AutoSize;
                    }));
                });
            }
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            Utility.CloseOneOpenOne(this, new MainForm(_userId));
        }
    }
}
