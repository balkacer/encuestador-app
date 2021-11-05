using Database.Models;
using Database.Services;
using System;
using System.Windows.Forms;
using Design.Utilities;
using System.Collections.Generic;

namespace Design
{
    public partial class MainForm : Form
    {
        private User user;
        private List<string> selectedQuiz = new();

        public MainForm(int id)
        {
            InitializeComponent();
            Init(id);
        }

        private async void Init(int id)
        {
            var userRes = await UserService.GetById(id);
            if (userRes.IsError)
            {
                MessageBox.Show(userRes.Msg,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                Utility.CloseOneOpenOne(this, new LoginForm());
            }
            else
            {
                user = userRes.Data;
                btnProfile.Text = 
                    user.Name[0].ToString() 
                    + user.LastName[0].ToString();
            }

            var quizRes = await QuizService.GetAllByUserId(user.Id);
            if (quizRes.IsError)
            {
                MessageBox.Show(quizRes.Msg,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                (quizRes.Data as List<Quiz>).ForEach((quiz) => {
                    dtGridView.Rows.Add(quiz.Id, quiz.Name, quiz.Respondents.Count);
                });
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Utility.CloseOneOpenOne(this, new LoginForm());
        }

        private void BtnAddQuiz_Click(object sender, EventArgs e)
        {
            new FirstStepCreateQuizForm(user.Id, this).Show();
        }

        private void DtGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var cellCount = dtGridView.Rows[index].Cells.Count;

            for (int i = 0; i < cellCount; i++)
            {
                var value = dtGridView.Rows[index].Cells[i].Value.ToString();
                selectedQuiz.Add(value);
            }

            lbSelectedQuizName.Text = selectedQuiz[1];
        }

        private void BtnAplyQuiz_Click(object sender, EventArgs e)
        {
            if (selectedQuiz.Count < 3)
            {
                MessageBox.Show("!Debe seleccionar una encuesta!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

            }
            else
            {
                Utility.CloseOneOpenOne(this, new AplyQuizForm(1, "Ramiro", int.Parse(selectedQuiz[0])));
            }
        }
    }
}
