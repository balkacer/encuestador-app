using Database.Services;
using Design.Utilities;
using System;
using System.Windows.Forms;

namespace Design
{
    public partial class LoginForm : Form
    {
        public LoginForm(string username = "", string password = "")
        {
            InitializeComponent();
            txtUsername.Text = username;
            txtPassword.Text = password;
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var res = await AuthService.Login(username, password);

            if (res.IsError)
            {
                MessageBox.Show(res.Msg,
                "Error de Inicio de sesión",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                Utility.CloseOneOpenOne(this, new MainForm(res.Data.Id));
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Utility.CloseOneOpenOne(this, new RegisterForm());
        }
    }
}
