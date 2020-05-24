namespace w61929_quiz
{
    partial class MainForm
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelCloseBtn = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMainLeft = new System.Windows.Forms.Panel();
            this.signInMenu1 = new w61929_quiz.SignInMenu();
            this.userStats1 = new w61929_quiz.UserStats();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scorePanel1 = new w61929_quiz.ScorePanel();
            this.votingPanel1 = new w61929_quiz.VotingPanel();
            this.listOfQuizzesPanel1 = new w61929_quiz.ListOfQuizzesPanel();
            this.loadingPanel1 = new w61929_quiz.LoadingPanel();
            this.welcomePanel1 = new w61929_quiz.WelcomePanel();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnUserIcon = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelCloseBtn.SuspendLayout();
            this.panelMainLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCloseBtn
            // 
            this.panelCloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCloseBtn.Controls.Add(this.btnClose);
            this.panelCloseBtn.Location = new System.Drawing.Point(1244, 5);
            this.panelCloseBtn.Name = "panelCloseBtn";
            this.panelCloseBtn.Size = new System.Drawing.Size(29, 25);
            this.panelCloseBtn.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnClose.BackgroundImage = global::w61929_quiz.Properties.Resources.btn_close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnClose.Location = new System.Drawing.Point(4, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 16);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseUp);
            // 
            // panelMainLeft
            // 
            this.panelMainLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelMainLeft.AutoSize = true;
            this.panelMainLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.panelMainLeft.Controls.Add(this.signInMenu1);
            this.panelMainLeft.Controls.Add(this.userStats1);
            this.panelMainLeft.Location = new System.Drawing.Point(85, 35);
            this.panelMainLeft.Name = "panelMainLeft";
            this.panelMainLeft.Size = new System.Drawing.Size(386, 1043);
            this.panelMainLeft.TabIndex = 7;
            // 
            // signInMenu1
            // 
            this.signInMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.signInMenu1.Location = new System.Drawing.Point(0, 0);
            this.signInMenu1.Name = "signInMenu1";
            this.signInMenu1.Size = new System.Drawing.Size(267, 582);
            this.signInMenu1.TabIndex = 2;
            // 
            // userStats1
            // 
            this.userStats1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.userStats1.Location = new System.Drawing.Point(0, 0);
            this.userStats1.Name = "userStats1";
            this.userStats1.Size = new System.Drawing.Size(267, 452);
            this.userStats1.TabIndex = 3;
            this.userStats1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.loadingPanel1);
            this.panel1.Controls.Add(this.welcomePanel1);
            this.panel1.Controls.Add(this.scorePanel1);
            this.panel1.Controls.Add(this.votingPanel1);
            this.panel1.Controls.Add(this.listOfQuizzesPanel1);
            this.panel1.Location = new System.Drawing.Point(354, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 685);
            this.panel1.TabIndex = 8;
            // 
            // scorePanel1
            // 
            this.scorePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scorePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.scorePanel1.Location = new System.Drawing.Point(76, 56);
            this.scorePanel1.Name = "scorePanel1";
            this.scorePanel1.Size = new System.Drawing.Size(776, 576);
            this.scorePanel1.TabIndex = 8;
            this.scorePanel1.Visible = false;
            this.scorePanel1.VisibleChanged += new System.EventHandler(this.scorePanel1_VisibleChanged);
            // 
            // votingPanel1
            // 
            this.votingPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.votingPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.votingPanel1.Location = new System.Drawing.Point(76, 76);
            this.votingPanel1.Name = "votingPanel1";
            this.votingPanel1.Size = new System.Drawing.Size(776, 536);
            this.votingPanel1.TabIndex = 7;
            this.votingPanel1.Visible = false;
            this.votingPanel1.VisibleChanged += new System.EventHandler(this.votingPanel1_VisibleChanged);
            // 
            // listOfQuizzesPanel1
            // 
            this.listOfQuizzesPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfQuizzesPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.listOfQuizzesPanel1.Location = new System.Drawing.Point(76, 55);
            this.listOfQuizzesPanel1.Name = "listOfQuizzesPanel1";
            this.listOfQuizzesPanel1.Size = new System.Drawing.Size(776, 567);
            this.listOfQuizzesPanel1.TabIndex = 6;
            this.listOfQuizzesPanel1.Visible = false;
            this.listOfQuizzesPanel1.VisibleChanged += new System.EventHandler(this.listOfQuizzesPanel1_VisibleChanged);
            // 
            // loadingPanel1
            // 
            this.loadingPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.loadingPanel1.Location = new System.Drawing.Point(76, 55);
            this.loadingPanel1.Name = "loadingPanel1";
            this.loadingPanel1.Size = new System.Drawing.Size(776, 576);
            this.loadingPanel1.TabIndex = 5;
            this.loadingPanel1.Visible = false;
            // 
            // welcomePanel1
            // 
            this.welcomePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.welcomePanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("welcomePanel1.BackgroundImage")));
            this.welcomePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.welcomePanel1.Location = new System.Drawing.Point(76, 76);
            this.welcomePanel1.Name = "welcomePanel1";
            this.welcomePanel1.Size = new System.Drawing.Size(776, 536);
            this.welcomePanel1.TabIndex = 4;
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnNormal.BackgroundImage = global::w61929_quiz.Properties.Resources.btn_normal;
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnNormal.FlatAppearance.BorderSize = 0;
            this.btnNormal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnNormal.Location = new System.Drawing.Point(1216, 9);
            this.btnNormal.Margin = new System.Windows.Forms.Padding(5);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(20, 18);
            this.btnNormal.TabIndex = 5;
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Visible = false;
            this.btnNormal.MouseEnter += new System.EventHandler(this.btnNormal_MouseEnter);
            this.btnNormal.MouseLeave += new System.EventHandler(this.btnNormal_MouseLeave);
            this.btnNormal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnNormal_MouseUp);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMin.BackgroundImage = global::w61929_quiz.Properties.Resources.btn_min;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMin.Location = new System.Drawing.Point(1186, 9);
            this.btnMin.Margin = new System.Windows.Forms.Padding(5);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(20, 18);
            this.btnMin.TabIndex = 4;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.MouseEnter += new System.EventHandler(this.btnMin_MouseEnter);
            this.btnMin.MouseLeave += new System.EventHandler(this.btnMin_MouseLeave);
            this.btnMin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMin_MouseUp);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMax.BackgroundImage = global::w61929_quiz.Properties.Resources.btn_max;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMax.Location = new System.Drawing.Point(1216, 9);
            this.btnMax.Margin = new System.Windows.Forms.Padding(5);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(20, 18);
            this.btnMax.TabIndex = 3;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.MouseEnter += new System.EventHandler(this.btnMax_MouseEnter);
            this.btnMax.MouseLeave += new System.EventHandler(this.btnMax_MouseLeave);
            this.btnMax.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMax_MouseUp);
            // 
            // btnUserIcon
            // 
            this.btnUserIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnUserIcon.BackgroundImage = global::w61929_quiz.Properties.Resources.user_icon;
            this.btnUserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUserIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserIcon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnUserIcon.FlatAppearance.BorderSize = 0;
            this.btnUserIcon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnUserIcon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnUserIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnUserIcon.Location = new System.Drawing.Point(7, 38);
            this.btnUserIcon.Name = "btnUserIcon";
            this.btnUserIcon.Size = new System.Drawing.Size(71, 71);
            this.btnUserIcon.TabIndex = 1;
            this.btnUserIcon.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMenu.BackgroundImage = global::w61929_quiz.Properties.Resources.menu_btn;
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.btnMenu.Location = new System.Drawing.Point(21, 137);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 30);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMainLeft);
            this.Controls.Add(this.panelCloseBtn);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnUserIcon);
            this.Controls.Add(this.btnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelCloseBtn.ResumeLayout(false);
            this.panelMainLeft.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnUserIcon;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Panel panelCloseBtn;
        private System.Windows.Forms.Panel panelMainLeft;
        private System.Windows.Forms.Panel panel1;
        private SignInMenu signInMenu1;
        private WelcomePanel welcomePanel1;
        private LoadingPanel loadingPanel1;
        private UserStats userStats1;
        private ListOfQuizzesPanel listOfQuizzesPanel1;
        private VotingPanel votingPanel1;
        private ScorePanel scorePanel1;
    }
}

