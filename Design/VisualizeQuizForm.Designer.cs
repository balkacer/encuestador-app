
namespace Design
{
    partial class VisualizeQuizForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizeQuizForm));
            this.dtGridViewRespondent = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRespondent = new System.Windows.Forms.Label();
            this.lbRespondentName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewRespondent)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridViewRespondent
            // 
            this.dtGridViewRespondent.AllowUserToAddRows = false;
            this.dtGridViewRespondent.AllowUserToDeleteRows = false;
            this.dtGridViewRespondent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridViewRespondent.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtGridViewRespondent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewRespondent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtGridViewRespondent.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGridViewRespondent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewRespondent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserName});
            this.dtGridViewRespondent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtGridViewRespondent.GridColor = System.Drawing.Color.White;
            this.dtGridViewRespondent.Location = new System.Drawing.Point(12, 85);
            this.dtGridViewRespondent.Name = "dtGridViewRespondent";
            this.dtGridViewRespondent.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkGreen;
            this.dtGridViewRespondent.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewRespondent.RowHeadersVisible = false;
            this.dtGridViewRespondent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtGridViewRespondent.RowTemplate.Height = 25;
            this.dtGridViewRespondent.Size = new System.Drawing.Size(460, 528);
            this.dtGridViewRespondent.TabIndex = 1;
            this.dtGridViewRespondent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtGridViewRespondent_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 60;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Nombre";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 400;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ver respuestas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbRespondent);
            this.panel1.Controls.Add(this.lbRespondentName);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 43);
            this.panel1.TabIndex = 12;
            // 
            // lbRespondent
            // 
            this.lbRespondent.AutoSize = true;
            this.lbRespondent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRespondent.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbRespondent.Location = new System.Drawing.Point(10, 11);
            this.lbRespondent.Name = "lbRespondent";
            this.lbRespondent.Size = new System.Drawing.Size(159, 19);
            this.lbRespondent.TabIndex = 8;
            this.lbRespondent.Text = "Persona seleccionada:";
            this.lbRespondent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbRespondentName
            // 
            this.lbRespondentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRespondentName.AutoSize = true;
            this.lbRespondentName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRespondentName.Location = new System.Drawing.Point(175, 14);
            this.lbRespondentName.Name = "lbRespondentName";
            this.lbRespondentName.Size = new System.Drawing.Size(52, 15);
            this.lbRespondentName.TabIndex = 9;
            this.lbRespondentName.Text = "Ninguna";
            this.lbRespondentName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // VisualizeQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtGridViewRespondent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 664);
            this.MinimumSize = new System.Drawing.Size(500, 664);
            this.Name = "VisualizeQuizForm";
            this.Text = "Visualizar Encuesta";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewRespondent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridViewRespondent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRespondent;
        private System.Windows.Forms.Label lbRespondentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
    }
}