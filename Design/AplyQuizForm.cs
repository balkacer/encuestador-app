using Database.Models;
using Database.Services;
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

            

            SetControllers(respondentName);
        }

        private async void GetQuiz(int id)
        {
            var res = await QuizService.GetQuizById(id);

            if (res.IsError)
            {
                MessageBox.Show(res.Msg,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                (res.Data as List<Quiz>).ForEach((quiz) => {
                    
                });
            }
        }

        private void SetControllers(string name)
        {
            lbRespondentName.Text = name;
        }
    }
}
