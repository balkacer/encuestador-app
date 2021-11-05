
namespace Design
{
    partial class AplyQuizForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRespondent = new System.Windows.Forms.Label();
            this.lbRespondentName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbRespondent);
            this.panel1.Controls.Add(this.lbRespondentName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 43);
            this.panel1.TabIndex = 11;
            // 
            // lbRespondent
            // 
            this.lbRespondent.AutoSize = true;
            this.lbRespondent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRespondent.ForeColor = System.Drawing.Color.MediumBlue;
            this.lbRespondent.Location = new System.Drawing.Point(14, 11);
            this.lbRespondent.Name = "lbRespondent";
            this.lbRespondent.Size = new System.Drawing.Size(165, 19);
            this.lbRespondent.TabIndex = 8;
            this.lbRespondent.Text = "Encuesta seleccionada:";
            this.lbRespondent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbRespondentName
            // 
            this.lbRespondentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRespondentName.AutoSize = true;
            this.lbRespondentName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRespondentName.Location = new System.Drawing.Point(185, 15);
            this.lbRespondentName.Name = "lbRespondentName";
            this.lbRespondentName.Size = new System.Drawing.Size(52, 15);
            this.lbRespondentName.TabIndex = 9;
            this.lbRespondentName.Text = "Ninguna";
            this.lbRespondentName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AplyQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 305);
            this.Controls.Add(this.panel1);
            this.Name = "AplyQuizForm";
            this.Text = "AplyQuizForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRespondent;
        private System.Windows.Forms.Label lbRespondentName;
    }
}