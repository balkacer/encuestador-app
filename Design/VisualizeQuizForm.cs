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
    public partial class VisualizeQuizForm : Form
    {
        private Quiz quiz;
        private readonly List<string> selectedQuiz = new();

        public VisualizeQuizForm(int quizId)
        {
            InitializeComponent();

            SetControllers(quizId);
        }

        private async void SetControllers(int id)
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
                this.Text += $" - {quiz.Name}";

                quiz.Respondents.ToList().ForEach((respondent) => {
                    dtGridViewRespondent.Rows.Add(respondent.Id, respondent.Name);
                });
            }));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (selectedQuiz.Count < 3)
            {
                MessageBox.Show("!Debe seleccionar una persona para ver las respuestas!",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                Utility.CloseOneOpenOne(this, new RespondentResponsesForm(int.Parse(selectedQuiz[0]), selectedQuiz[1], quiz.UserId));
            }
        }

        private void DtGridViewRespondent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var cellCount = dtGridViewRespondent.Rows[index].Cells.Count;

            for (int i = 0; i < cellCount; i++)
            {
                var value = dtGridViewRespondent.Rows[index].Cells[i].Value.ToString();
                selectedQuiz.Add(value);
            }

            lbRespondentName.Text = selectedQuiz[1];
        }
    }
}
