
namespace Design
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResposeQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddQuiz = new System.Windows.Forms.Button();
            this.btnDeleteQuiz = new System.Windows.Forms.Button();
            this.btnEditQuiz = new System.Windows.Forms.Button();
            this.btnAplyQuiz = new System.Windows.Forms.Button();
            this.btnVisualizeQuiz = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lbSelectedQuizLabel = new System.Windows.Forms.Label();
            this.lbSelectedQuizName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.AllowUserToDeleteRows = false;
            this.dtGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserName,
            this.ResposeQuantity});
            this.dtGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtGridView.GridColor = System.Drawing.Color.White;
            this.dtGridView.Location = new System.Drawing.Point(12, 188);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkGreen;
            this.dtGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridView.RowHeadersVisible = false;
            this.dtGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtGridView.RowTemplate.Height = 25;
            this.dtGridView.Size = new System.Drawing.Size(814, 398);
            this.dtGridView.TabIndex = 0;
            this.dtGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGridView_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 64;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Nombre";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 550;
            // 
            // ResposeQuantity
            // 
            this.ResposeQuantity.HeaderText = "Cantidad de Respuestas";
            this.ResposeQuantity.Name = "ResposeQuantity";
            this.ResposeQuantity.ReadOnly = true;
            this.ResposeQuantity.Width = 200;
            // 
            // btnAddQuiz
            // 
            this.btnAddQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQuiz.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAddQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddQuiz.FlatAppearance.BorderSize = 0;
            this.btnAddQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuiz.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddQuiz.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddQuiz.Location = new System.Drawing.Point(680, 597);
            this.btnAddQuiz.Name = "btnAddQuiz";
            this.btnAddQuiz.Size = new System.Drawing.Size(146, 43);
            this.btnAddQuiz.TabIndex = 1;
            this.btnAddQuiz.Text = "Crear Encuesta";
            this.btnAddQuiz.UseVisualStyleBackColor = false;
            this.btnAddQuiz.Click += new System.EventHandler(this.BtnAddQuiz_Click);
            // 
            // btnDeleteQuiz
            // 
            this.btnDeleteQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteQuiz.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteQuiz.FlatAppearance.BorderSize = 0;
            this.btnDeleteQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteQuiz.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteQuiz.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteQuiz.Location = new System.Drawing.Point(12, 597);
            this.btnDeleteQuiz.Name = "btnDeleteQuiz";
            this.btnDeleteQuiz.Size = new System.Drawing.Size(146, 43);
            this.btnDeleteQuiz.TabIndex = 2;
            this.btnDeleteQuiz.Text = "Eliminar Encuesta";
            this.btnDeleteQuiz.UseVisualStyleBackColor = false;
            // 
            // btnEditQuiz
            // 
            this.btnEditQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditQuiz.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditQuiz.FlatAppearance.BorderSize = 0;
            this.btnEditQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditQuiz.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditQuiz.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditQuiz.Location = new System.Drawing.Point(523, 597);
            this.btnEditQuiz.Name = "btnEditQuiz";
            this.btnEditQuiz.Size = new System.Drawing.Size(146, 43);
            this.btnEditQuiz.TabIndex = 3;
            this.btnEditQuiz.Text = "Editar Encuesta";
            this.btnEditQuiz.UseVisualStyleBackColor = false;
            // 
            // btnAplyQuiz
            // 
            this.btnAplyQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplyQuiz.BackColor = System.Drawing.Color.Blue;
            this.btnAplyQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplyQuiz.FlatAppearance.BorderSize = 0;
            this.btnAplyQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplyQuiz.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAplyQuiz.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAplyQuiz.Location = new System.Drawing.Point(12, 134);
            this.btnAplyQuiz.Name = "btnAplyQuiz";
            this.btnAplyQuiz.Size = new System.Drawing.Size(188, 43);
            this.btnAplyQuiz.TabIndex = 5;
            this.btnAplyQuiz.Text = "Aplicar Encuesta";
            this.btnAplyQuiz.UseVisualStyleBackColor = false;
            this.btnAplyQuiz.Click += new System.EventHandler(this.BtnAplyQuiz_Click);
            // 
            // btnVisualizeQuiz
            // 
            this.btnVisualizeQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVisualizeQuiz.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVisualizeQuiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizeQuiz.FlatAppearance.BorderSize = 0;
            this.btnVisualizeQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizeQuiz.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizeQuiz.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVisualizeQuiz.Location = new System.Drawing.Point(211, 134);
            this.btnVisualizeQuiz.Name = "btnVisualizeQuiz";
            this.btnVisualizeQuiz.Size = new System.Drawing.Size(188, 43);
            this.btnVisualizeQuiz.TabIndex = 4;
            this.btnVisualizeQuiz.Text = "Visualizar Encuesta";
            this.btnVisualizeQuiz.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(680, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(146, 43);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Cerrar Sesión";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProfile.BackColor = System.Drawing.Color.Black;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProfile.Location = new System.Drawing.Point(12, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(48, 43);
            this.btnProfile.TabIndex = 7;
            this.btnProfile.Text = "AB";
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // lbSelectedQuizLabel
            // 
            this.lbSelectedQuizLabel.AutoSize = true;
            this.lbSelectedQuizLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSelectedQuizLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbSelectedQuizLabel.Location = new System.Drawing.Point(14, 11);
            this.lbSelectedQuizLabel.Name = "lbSelectedQuizLabel";
            this.lbSelectedQuizLabel.Size = new System.Drawing.Size(165, 19);
            this.lbSelectedQuizLabel.TabIndex = 8;
            this.lbSelectedQuizLabel.Text = "Encuesta seleccionada:";
            this.lbSelectedQuizLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbSelectedQuizName
            // 
            this.lbSelectedQuizName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSelectedQuizName.AutoSize = true;
            this.lbSelectedQuizName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSelectedQuizName.Location = new System.Drawing.Point(185, 13);
            this.lbSelectedQuizName.Name = "lbSelectedQuizName";
            this.lbSelectedQuizName.Size = new System.Drawing.Size(52, 15);
            this.lbSelectedQuizName.TabIndex = 9;
            this.lbSelectedQuizName.Text = "Ninguna";
            this.lbSelectedQuizName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbSelectedQuizLabel);
            this.panel1.Controls.Add(this.lbSelectedQuizName);
            this.panel1.Location = new System.Drawing.Point(411, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 43);
            this.panel1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(838, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnAplyQuiz);
            this.Controls.Add(this.btnVisualizeQuiz);
            this.Controls.Add(this.btnEditQuiz);
            this.Controls.Add(this.btnDeleteQuiz);
            this.Controls.Add(this.btnAddQuiz);
            this.Controls.Add(this.dtGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EncuestadorApp";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.Button btnAddQuiz;
        private System.Windows.Forms.Button btnDeleteQuiz;
        private System.Windows.Forms.Button btnEditQuiz;
        private System.Windows.Forms.Button btnAplyQuiz;
        private System.Windows.Forms.Button btnVisualizeQuiz;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lbSelectedQuizLabel;
        private System.Windows.Forms.Label lbSelectedQuizName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResposeQuantity;
    }
}

