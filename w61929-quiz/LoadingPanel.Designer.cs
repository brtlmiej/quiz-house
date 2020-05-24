namespace w61929_quiz
{
    partial class LoadingPanel
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
            this.components = new System.ComponentModel.Container();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelLoadBack = new System.Windows.Forms.Panel();
            this.panelLoad = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelLoadBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.Image = global::w61929_quiz.Properties.Resources.loading;
            this.logo.Location = new System.Drawing.Point(0, 115);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(773, 232);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // panelLoadBack
            // 
            this.panelLoadBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLoadBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(74)))));
            this.panelLoadBack.Controls.Add(this.panelLoad);
            this.panelLoadBack.Location = new System.Drawing.Point(0, 452);
            this.panelLoadBack.Name = "panelLoadBack";
            this.panelLoadBack.Size = new System.Drawing.Size(776, 10);
            this.panelLoadBack.TabIndex = 2;
            // 
            // panelLoad
            // 
            this.panelLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.panelLoad.Location = new System.Drawing.Point(0, 0);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(67, 10);
            this.panelLoad.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // LoadingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panelLoadBack);
            this.Controls.Add(this.logo);
            this.Name = "LoadingPanel";
            this.Size = new System.Drawing.Size(776, 576);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelLoadBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panelLoadBack;
        private System.Windows.Forms.Panel panelLoad;
        private System.Windows.Forms.Timer timer;
    }
}
