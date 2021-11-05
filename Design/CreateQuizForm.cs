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
    public partial class CreateQuizForm : Form
    {
        private int _userId;
        private int _questionsQuantity;
        private string _quizName;
        public CreateQuizForm(int userId, int questionsQuantity, string quizName)
        {
            InitializeComponent();
            _userId = userId;
            _questionsQuantity = questionsQuantity;
            _quizName = quizName;

            SetControllers();
        }

        private void SetControllers()
        {
            lbQuizName.Text = _quizName;

            for (int i = 0; i < _questionsQuantity; i++)
            {
                var txtQuestion = new TextBox
                {
                    Multiline = true,
                    Height = 30,
                    BorderStyle = BorderStyle.None,
                    Width = table.Width - 20,
                    Name = "txtQuestion" + (i + 1),
                    Margin = new Padding(10),
                    Font = new Font("Calibri", 10, FontStyle.Bold)
                };

                var lbQuestion = new Label
                {
                    Name = "lbQuestion" + (i + 1),
                    Text = "Pregunta #" + (i + 1),
                    Font = new Font("Calibri", 10, FontStyle.Bold)
                };


                table.Controls.Add(lbQuestion, 0, i);
                table.Controls.Add(txtQuestion, 1, i);

                table.RowStyles[0].SizeType = SizeType.AutoSize;
            }
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            List<string> questions = new();

            for (int i = 1; i <= _questionsQuantity; i++)
            {
                int index = (i * 2) - 1;

                var question = table.Controls[index].Text;

                questions.Add(question);
            }

            var res = await QuizService.Create(_quizName, _userId, questions);

            if (res.IsError)
            {
                MessageBox.Show(res.Msg,
                "Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(res.Msg,
                "Proceso Exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                Utility.CloseOneOpenOne(this, new MainForm(_userId));
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Utility.CloseOneOpenOne(this, new MainForm(_userId));
        }
    }
}
