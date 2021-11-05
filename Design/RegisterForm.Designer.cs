
namespace Design
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lbLastname = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lbConfirmPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(29, 323);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(306, 35);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.ForeColor = System.Drawing.Color.Black;
            this.lbPassword.Location = new System.Drawing.Point(29, 295);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(86, 19);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Contraseña";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(29, 236);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(306, 35);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.WordWrap = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.ForeColor = System.Drawing.Color.Black;
            this.lbUsername.Location = new System.Drawing.Point(29, 209);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(61, 19);
            this.lbUsername.TabIndex = 7;
            this.lbUsername.Text = "Usuario";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(182, 489);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(153, 45);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(29, 489);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 45);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(29, 64);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(306, 35);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(29, 36);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(65, 19);
            this.lbName.TabIndex = 12;
            this.lbName.Text = "Nombre";
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.Color.White;
            this.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLastname.ForeColor = System.Drawing.Color.Black;
            this.txtLastname.Location = new System.Drawing.Point(29, 148);
            this.txtLastname.Multiline = true;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(306, 35);
            this.txtLastname.TabIndex = 1;
            this.txtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbLastname.ForeColor = System.Drawing.Color.Black;
            this.lbLastname.Location = new System.Drawing.Point(29, 120);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(66, 19);
            this.lbLastname.TabIndex = 14;
            this.lbLastname.Text = "Apellido";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.White;
            this.txtConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtConfirmPass.ForeColor = System.Drawing.Color.Black;
            this.txtConfirmPass.Location = new System.Drawing.Point(29, 409);
            this.txtConfirmPass.Multiline = true;
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(306, 35);
            this.txtConfirmPass.TabIndex = 4;
            this.txtConfirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbConfirmPass
            // 
            this.lbConfirmPass.AutoSize = true;
            this.lbConfirmPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbConfirmPass.ForeColor = System.Drawing.Color.Black;
            this.lbConfirmPass.Location = new System.Drawing.Point(29, 381);
            this.lbConfirmPass.Name = "lbConfirmPass";
            this.lbConfirmPass.Size = new System.Drawing.Size(158, 19);
            this.lbConfirmPass.TabIndex = 16;
            this.lbConfirmPass.Text = "Confirmar Contraseña";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(364, 562);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.lbConfirmPass);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lbConfirmPass;
    }
}