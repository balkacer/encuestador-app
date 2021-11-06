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
    public partial class AddRespondentForm : Form
    {
        private readonly int _quizId;
        public AddRespondentForm(int quizId)
        {
            InitializeComponent();
            _quizId = quizId;
        }

        private async void BtnNext_Click(object sender, EventArgs e)
        {
            var name = txtRespondentName.Text;

            if (name != "")
            {
                var res = await RespondentService.AddNew(name, _quizId);

                if (res.IsError)
                {
                    MessageBox.Show(
                    res.Msg,
                "Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                }
                else
                {
                    Utility.CloseOneOpenOne(this, new AplyQuizForm((res.Data as Respondent).Id, name, _quizId));
                }
            } else
            {
                MessageBox.Show(
                    "¡Debe introducir su nombre para continuar!",
                "Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
