
namespace Design
{
    partial class FirstStepCreateQuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstStepCreateQuizForm));
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtQuestionQuantity = new System.Windows.Forms.TextBox();
            this.lbQuestionQuantity = new System.Windows.Forms.Label();
            this.txtQuizName = new System.Windows.Forms.TextBox();
            this.lbQuizName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(213, 176);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 38);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Siguiente";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(12, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 38);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // txtQuestionQuantity
            // 
            this.txtQuestionQuantity.BackColor = System.Drawing.Color.White;
            this.txtQuestionQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestionQuantity.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtQuestionQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuestionQuantity.Location = new System.Drawing.Point(15, 123);
            this.txtQuestionQuantity.Multiline = true;
            this.txtQuestionQuantity.Name = "txtQuestionQuantity";
            this.txtQuestionQuantity.Size = new System.Drawing.Size(306, 35);
            this.txtQuestionQuantity.TabIndex = 6;
            this.txtQuestionQuantity.Text = "0";
            this.txtQuestionQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuestionQuantity.TextChanged += new System.EventHandler(this.TxtQuestionQuantity_TextChanged);
            this.txtQuestionQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuestionQuantity_KeyPress);
            // 
            // lbQuestionQuantity
            // 
            this.lbQuestionQuantity.AutoSize = true;
            this.lbQuestionQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQuestionQuantity.ForeColor = System.Drawing.Color.Black;
            this.lbQuestionQuantity.Location = new System.Drawing.Point(15, 95);
            this.lbQuestionQuantity.Name = "lbQuestionQuantity";
            this.lbQuestionQuantity.Size = new System.Drawing.Size(163, 19);
            this.lbQuestionQuantity.TabIndex = 8;
            this.lbQuestionQuantity.Text = "Cantidad de preguntas";
            // 
            // txtQuizName
            // 
            this.txtQuizName.BackColor = System.Drawing.Color.White;
            this.txtQuizName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuizName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtQuizName.ForeColor = System.Drawing.Color.Black;
            this.txtQuizName.Location = new System.Drawing.Point(15, 44);
            this.txtQuizName.Multiline = true;
            this.txtQuizName.Name = "txtQuizName";
            this.txtQuizName.Size = new System.Drawing.Size(306, 35);
            this.txtQuizName.TabIndex = 5;
            this.txtQuizName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuizName.WordWrap = false;
            // 
            // lbQuizName
            // 
            this.lbQuizName.AutoSize = true;
            this.lbQuizName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbQuizName.ForeColor = System.Drawing.Color.Black;
            this.lbQuizName.Location = new System.Drawing.Point(15, 17);
            this.lbQuizName.Name = "lbQuizName";
            this.lbQuizName.Size = new System.Drawing.Size(167, 19);
            this.lbQuizName.TabIndex = 7;
            this.lbQuizName.Text = "Nombre de la encuesta";
            // 
            // FirstStepCreateQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 226);
            this.Controls.Add(this.txtQuestionQuantity);
            this.Controls.Add(this.lbQuestionQuantity);
            this.Controls.Add(this.txtQuizName);
            this.Controls.Add(this.lbQuizName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(349, 265);
            this.MinimumSize = new System.Drawing.Size(349, 265);
            this.Name = "FirstStepCreateQuizForm";
            this.Text = "Crear Nueva Encuesta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtQuestionQuantity;
        private System.Windows.Forms.Label lbQuestionQuantity;
        private System.Windows.Forms.TextBox txtQuizName;
        private System.Windows.Forms.Label lbQuizName;
    }
}