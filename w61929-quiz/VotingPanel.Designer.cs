namespace w61929_quiz
{
    partial class VotingPanel
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
            this.voteQuestionIndex = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.voteNumOfQuestions = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rBtn1 = new System.Windows.Forms.RadioButton();
            this.panelRadioBtns = new System.Windows.Forms.Panel();
            this.rBtn4 = new System.Windows.Forms.RadioButton();
            this.rBtn3 = new System.Windows.Forms.RadioButton();
            this.rBtn2 = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.voteQuestionText = new System.Windows.Forms.TextBox();
            this.panelRadioBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // voteQuestionIndex
            // 
            this.voteQuestionIndex.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.voteQuestionIndex.Font = new System.Drawing.Font("Bahnschrift", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.voteQuestionIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(163)))));
            this.voteQuestionIndex.Location = new System.Drawing.Point(339, 1);
            this.voteQuestionIndex.Margin = new System.Windows.Forms.Padding(1);
            this.voteQuestionIndex.Name = "voteQuestionIndex";
            this.voteQuestionIndex.Size = new System.Drawing.Size(33, 37);
            this.voteQuestionIndex.TabIndex = 1;
            this.voteQuestionIndex.Text = " 1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(374, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "of";
            // 
            // voteNumOfQuestions
            // 
            this.voteNumOfQuestions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.voteNumOfQuestions.AutoSize = true;
            this.voteNumOfQuestions.Font = new System.Drawing.Font("Bahnschrift", 18.32727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.voteNumOfQuestions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(163)))));
            this.voteNumOfQuestions.Location = new System.Drawing.Point(415, 1);
            this.voteNumOfQuestions.Margin = new System.Windows.Forms.Padding(1);
            this.voteNumOfQuestions.Name = "voteNumOfQuestions";
            this.voteNumOfQuestions.Size = new System.Drawing.Size(39, 34);
            this.voteNumOfQuestions.TabIndex = 3;
            this.voteNumOfQuestions.Text = "10";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 22.25455F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(163)))));
            this.label2.Location = new System.Drawing.Point(1, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Q:";
            // 
            // rBtn1
            // 
            this.rBtn1.AutoSize = true;
            this.rBtn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rBtn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(163)))));
            this.rBtn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(163)))));
            this.rBtn1.Font = new System.Drawing.Font("Bahnschrift", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rBtn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(118)))));
            this.rBtn1.Location = new System.Drawing.Point(3, 3);
            this.rBtn1.Name = "rBtn1";
            this.rBtn1.Size = new System.Drawing.Size(133, 27);
            this.rBtn1.TabIndex = 6;
            this.rBtn1.TabStop = true;
            this.rBtn1.Text = "radioButton1";
            this.rBtn1.UseVisualStyleBackColor = true;
            // 
            // panelRadioBtns
            // 
            this.panelRadioBtns.Controls.Add(this.rBtn4);
            this.panelRadioBtns.Controls.Add(this.rBtn3);
            this.panelRadioBtns.Controls.Add(this.rBtn2);
            this.panelRadioBtns.Controls.Add(this.rBtn1);
            this.panelRadioBtns.Location = new System.Drawing.Point(57, 219);
            this.panelRadioBtns.Name = "panelRadioBtns";
            this.panelRadioBtns.Size = new System.Drawing.Size(666, 220);
            this.panelRadioBtns.TabIndex = 7;
            // 
            // rBtn4
            // 
            this.rBtn4.AutoSize = true;
            this.rBtn4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rBtn4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(163)))));
            this.rBtn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(163)))));
            this.rBtn4.Font = new System.Drawing.Font("Bahnschrift", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rBtn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(118)))));
            this.rBtn4.Location = new System.Drawing.Point(3, 183);
            this.rBtn4.Name = "rBtn4";
            this.rBtn4.Size = new System.Drawing.Size(133, 27);
            this.rBtn4.TabIndex = 9;
            this.rBtn4.TabStop = true;
            this.rBtn4.Text = "radioButton1";
            this.rBtn4.UseVisualStyleBackColor = true;
            // 
            // rBtn3
            // 
            this.rBtn3.AutoSize = true;
            this.rBtn3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rBtn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(163)))));
            this.rBtn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(163)))));
            this.rBtn3.Font = new System.Drawing.Font("Bahnschrift", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rBtn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(118)))));
            this.rBtn3.Location = new System.Drawing.Point(3, 123);
            this.rBtn3.Name = "rBtn3";
            this.rBtn3.Size = new System.Drawing.Size(133, 27);
            this.rBtn3.TabIndex = 8;
            this.rBtn3.TabStop = true;
            this.rBtn3.Text = "radioButton1";
            this.rBtn3.UseVisualStyleBackColor = true;
            // 
            // rBtn2
            // 
            this.rBtn2.AutoSize = true;
            this.rBtn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rBtn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(163)))));
            this.rBtn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(163)))));
            this.rBtn2.Font = new System.Drawing.Font("Bahnschrift", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rBtn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(118)))));
            this.rBtn2.Location = new System.Drawing.Point(3, 63);
            this.rBtn2.Name = "rBtn2";
            this.rBtn2.Size = new System.Drawing.Size(133, 27);
            this.rBtn2.TabIndex = 7;
            this.rBtn2.TabStop = true;
            this.rBtn2.Text = "radioButton1";
            this.rBtn2.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackgroundImage = global::w61929_quiz.Properties.Resources.btn_Next;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(662, 478);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(111, 55);
            this.btnNext.TabIndex = 8;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.btnNext_MouseEnter);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            // 
            // btnFinish
            // 
            this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinish.BackgroundImage = global::w61929_quiz.Properties.Resources.btn_finish;
            this.btnFinish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFinish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinish.Enabled = false;
            this.btnFinish.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btnFinish.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Location = new System.Drawing.Point(535, 478);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(111, 55);
            this.btnFinish.TabIndex = 9;
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            this.btnFinish.MouseEnter += new System.EventHandler(this.btnFinish_MouseEnter);
            this.btnFinish.MouseLeave += new System.EventHandler(this.btnFinish_MouseLeave);
            // 
            // voteQuestionText
            // 
            this.voteQuestionText.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.voteQuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voteQuestionText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.voteQuestionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.voteQuestionText.Font = new System.Drawing.Font("Bahnschrift", 18.32727F);
            this.voteQuestionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.voteQuestionText.Location = new System.Drawing.Point(54, 93);
            this.voteQuestionText.Multiline = true;
            this.voteQuestionText.Name = "voteQuestionText";
            this.voteQuestionText.Size = new System.Drawing.Size(663, 109);
            this.voteQuestionText.TabIndex = 10;
            this.voteQuestionText.Text = "asas";
            // 
            // VotingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.voteQuestionText);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panelRadioBtns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.voteNumOfQuestions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.voteQuestionIndex);
            this.Name = "VotingPanel";
            this.Size = new System.Drawing.Size(776, 536);
            this.panelRadioBtns.ResumeLayout(false);
            this.panelRadioBtns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label voteQuestionIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label voteNumOfQuestions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rBtn1;
        private System.Windows.Forms.Panel panelRadioBtns;
        private System.Windows.Forms.RadioButton rBtn4;
        private System.Windows.Forms.RadioButton rBtn3;
        private System.Windows.Forms.RadioButton rBtn2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox voteQuestionText;
    }
}
