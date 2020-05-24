namespace w61929_quiz
{
    partial class UserStats
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.panelForStats = new System.Windows.Forms.Panel();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblQuizzes = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.panelForStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Bahnschrift", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(163)))));
            this.lblUserName.Location = new System.Drawing.Point(0, 18);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(264, 36);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User Name";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelForStats
            // 
            this.panelForStats.BackgroundImage = global::w61929_quiz.Properties.Resources.l_screen_after_sign_in;
            this.panelForStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelForStats.Controls.Add(this.lblRank);
            this.panelForStats.Controls.Add(this.lblQuizzes);
            this.panelForStats.Controls.Add(this.lblPoints);
            this.panelForStats.Location = new System.Drawing.Point(24, 101);
            this.panelForStats.Name = "panelForStats";
            this.panelForStats.Size = new System.Drawing.Size(196, 227);
            this.panelForStats.TabIndex = 2;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Bahnschrift", 18.98182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(174)))), ((int)(((byte)(30)))));
            this.lblRank.Location = new System.Drawing.Point(33, 168);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(44, 36);
            this.lblRank.TabIndex = 0;
            this.lblRank.Text = "#1";
            // 
            // lblQuizzes
            // 
            this.lblQuizzes.AutoSize = true;
            this.lblQuizzes.Font = new System.Drawing.Font("Bahnschrift", 18.98182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuizzes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.lblQuizzes.Location = new System.Drawing.Point(33, 82);
            this.lblQuizzes.Name = "lblQuizzes";
            this.lblQuizzes.Size = new System.Drawing.Size(32, 36);
            this.lblQuizzes.TabIndex = 0;
            this.lblQuizzes.Text = "0";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Bahnschrift", 18.98182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(175)))), ((int)(((byte)(50)))));
            this.lblPoints.Location = new System.Drawing.Point(33, -7);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(54, 36);
            this.lblPoints.TabIndex = 0;
            this.lblPoints.Text = "0.0";
            // 
            // UserStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.panelForStats);
            this.Name = "UserStats";
            this.Size = new System.Drawing.Size(267, 452);
            this.panelForStats.ResumeLayout(false);
            this.panelForStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panelForStats;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblQuizzes;
        private System.Windows.Forms.Label lblPoints;
    }
}
