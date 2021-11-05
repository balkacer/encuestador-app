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
    public partial class FirstStepCreateQuizForm : Form
    {
        private readonly int _userId;
        private readonly Form _mainForm;
        public FirstStepCreateQuizForm(int userId, Form mainForm)
        {
            InitializeComponent();
            _userId = userId;
            _mainForm = mainForm;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            _mainForm.FormClosed += (s, args) => this.Close();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            var questionQuantity = int.Parse(txtQuestionQuantity.Text.Trim());
            var quizName = txtQuizName.Text.TrimEnd().TrimStart();

            if (questionQuantity <= 0 || quizName == "")
            {
                MessageBox.Show(
                "¡Todos los campos son requeridos!",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else
            {
                _mainForm.Hide();
                this.FormClosed += (s, args) => _mainForm.Close();
                Utility.CloseOneOpenOne(this, new CreateQuizForm(_userId, questionQuantity, quizName));
            }
        }

        private void TxtQuestionQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtQuestionQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuestionQuantity.Text.Length < 1)
                txtQuestionQuantity.Text = "0";
        }
    }
}
