namespace w61929_quiz
{
    partial class ListOfQuizzesPanel
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
            this.panellistQuizzes = new System.Windows.Forms.Panel();
            this.screenQuizzes = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panellistQuizzes
            // 
            this.panellistQuizzes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panellistQuizzes.BackgroundImage = global::w61929_quiz.Properties.Resources.list_of_quizzes;
            this.panellistQuizzes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panellistQuizzes.Location = new System.Drawing.Point(12, 3);
            this.panellistQuizzes.Name = "panellistQuizzes";
            this.panellistQuizzes.Size = new System.Drawing.Size(760, 45);
            this.panellistQuizzes.TabIndex = 3;
            // 
            // screenQuizzes
            // 
            this.screenQuizzes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screenQuizzes.AutoScroll = true;
            this.screenQuizzes.Location = new System.Drawing.Point(3, 106);
            this.screenQuizzes.Name = "screenQuizzes";
            this.screenQuizzes.Size = new System.Drawing.Size(770, 457);
            this.screenQuizzes.TabIndex = 4;
            // 
            // ListOfQuizzesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panellistQuizzes);
            this.Controls.Add(this.screenQuizzes);
            this.Name = "ListOfQuizzesPanel";
            this.Size = new System.Drawing.Size(776, 567);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellistQuizzes;
        private System.Windows.Forms.FlowLayoutPanel screenQuizzes;
    }
}
