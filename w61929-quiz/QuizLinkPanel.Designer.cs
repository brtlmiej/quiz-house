namespace w61929_quiz
{
    partial class QuizLinkPanel
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuizTitle = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QuizCategory = new System.Windows.Forms.Label();
            this.QuizNumOfQuestions = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuizTitle
            // 
            this.QuizTitle.AutoSize = true;
            this.QuizTitle.Font = new System.Drawing.Font("Bahnschrift", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuizTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.QuizTitle.Location = new System.Drawing.Point(14, 14);
            this.QuizTitle.Name = "QuizTitle";
            this.QuizTitle.Size = new System.Drawing.Size(193, 29);
            this.QuizTitle.TabIndex = 0;
            this.QuizTitle.Text = "Linear Equations";
            this.QuizTitle.Click += new System.EventHandler(this.child_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Bahnschrift", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(118)))));
            this.lblCategory.Location = new System.Drawing.Point(15, 75);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(82, 23);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "category";
            this.lblCategory.Click += new System.EventHandler(this.child_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(118)))));
            this.label1.Location = new System.Drawing.Point(15, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "number of questions";
            this.label1.Click += new System.EventHandler(this.child_Click);
            // 
            // QuizCategory
            // 
            this.QuizCategory.AutoSize = true;
            this.QuizCategory.Font = new System.Drawing.Font("Bahnschrift", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuizCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.QuizCategory.Location = new System.Drawing.Point(103, 69);
            this.QuizCategory.Name = "QuizCategory";
            this.QuizCategory.Size = new System.Drawing.Size(66, 29);
            this.QuizCategory.TabIndex = 3;
            this.QuizCategory.Text = "Math";
            this.QuizCategory.Click += new System.EventHandler(this.child_Click);
            // 
            // QuizNumOfQuestions
            // 
            this.QuizNumOfQuestions.AutoSize = true;
            this.QuizNumOfQuestions.Font = new System.Drawing.Font("Bahnschrift", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuizNumOfQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.QuizNumOfQuestions.Location = new System.Drawing.Point(206, 107);
            this.QuizNumOfQuestions.Name = "QuizNumOfQuestions";
            this.QuizNumOfQuestions.Size = new System.Drawing.Size(35, 29);
            this.QuizNumOfQuestions.TabIndex = 4;
            this.QuizNumOfQuestions.Text = "18";
            this.QuizNumOfQuestions.Click += new System.EventHandler(this.child_Click);
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.Font = new System.Drawing.Font("Bahnschrift", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.start.Location = new System.Drawing.Point(192, 167);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(131, 39);
            this.start.TabIndex = 5;
            this.start.Text = "< start >";
            this.start.Click += new System.EventHandler(this.child_Click);
            // 
            // QuizLinkPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.start);
            this.Controls.Add(this.QuizNumOfQuestions);
            this.Controls.Add(this.QuizCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.QuizTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(20, 50, 20, 50);
            this.Name = "QuizLinkPanel";
            this.Size = new System.Drawing.Size(333, 223);
            this.Load += new System.EventHandler(this.QuizLinkPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuizTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label QuizCategory;
        private System.Windows.Forms.Label QuizNumOfQuestions;
        private System.Windows.Forms.Label start;
    }
}
