
namespace Design
{
    partial class RespondentResponsesForm
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
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbRespondent = new System.Windows.Forms.Label();
            this.lbRespondentName = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnCount = 1;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.Location = new System.Drawing.Point(12, 75);
            this.table.Name = "table";
            this.table.RowCount = 1;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Size = new System.Drawing.Size(361, 305);
            this.table.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbRespondent);
            this.panel1.Controls.Add(this.lbRespondentName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 43);
            this.panel1.TabIndex = 13;
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
            this.lbRespondentName.Location = new System.Drawing.Point(171, 14);
            this.lbRespondentName.Name = "lbRespondentName";
            this.lbRespondentName.Size = new System.Drawing.Size(52, 15);
            this.lbRespondentName.TabIndex = 9;
            this.lbRespondentName.Text = "Ninguna";
            this.lbRespondentName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(264, 397);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(109, 43);
            this.btnGoBack.TabIndex = 14;
            this.btnGoBack.Text = "Volver atras";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.BtnGoBack_Click);
            // 
            // RespondentResponsesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 452);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.table);
            this.Name = "RespondentResponsesForm";
            this.Text = "Respuestas de - ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRespondent;
        private System.Windows.Forms.Label lbRespondentName;
        private System.Windows.Forms.Button btnGoBack;
    }
}