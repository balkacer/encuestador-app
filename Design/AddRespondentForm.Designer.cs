
namespace Design
{
    partial class AddRespondentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRespondentForm));
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtRespondentName = new System.Windows.Forms.TextBox();
            this.lbRespondantName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(209, 162);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(109, 43);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Siguiente";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(94, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 43);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtRespondentName
            // 
            this.txtRespondentName.BackColor = System.Drawing.Color.White;
            this.txtRespondentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespondentName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRespondentName.ForeColor = System.Drawing.Color.Black;
            this.txtRespondentName.Location = new System.Drawing.Point(12, 38);
            this.txtRespondentName.Multiline = true;
            this.txtRespondentName.Name = "txtRespondentName";
            this.txtRespondentName.Size = new System.Drawing.Size(306, 35);
            this.txtRespondentName.TabIndex = 3;
            this.txtRespondentName.WordWrap = false;
            // 
            // lbRespondantName
            // 
            this.lbRespondantName.AutoSize = true;
            this.lbRespondantName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRespondantName.ForeColor = System.Drawing.Color.Black;
            this.lbRespondantName.Location = new System.Drawing.Point(12, 11);
            this.lbRespondantName.Name = "lbRespondantName";
            this.lbRespondantName.Size = new System.Drawing.Size(169, 19);
            this.lbRespondantName.TabIndex = 4;
            this.lbRespondantName.Text = "Nombre de encuestado";
            // 
            // AddRespondentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 217);
            this.Controls.Add(this.txtRespondentName);
            this.Controls.Add(this.lbRespondantName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(346, 256);
            this.MinimumSize = new System.Drawing.Size(346, 256);
            this.Name = "AddRespondentForm";
            this.Text = "Agregar Encuestado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtRespondentName;
        private System.Windows.Forms.Label lbRespondantName;
    }
}