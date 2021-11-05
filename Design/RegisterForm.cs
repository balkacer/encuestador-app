using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database.Services;
using Design.Utilities;

namespace Design
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var pass = txtPassword.Text;
            var confirmPass = txtConfirmPass.Text;
            var name = txtName.Text;
            var last = txtLastname.Text;

            var res = await AuthService.Register(name, last, username, pass, confirmPass);

            if (res.IsError)
            {
                MessageBox.Show(res.Msg,
                "Error de Registro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(res.Msg,
                "Registro exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                Utility.CloseOneOpenOne(this, new LoginForm());
            }            
        }
    }
}
