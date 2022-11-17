namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.Headerlabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.UnplayedCheckBox = new System.Windows.Forms.CheckBox();
            this.MatchupListbox = new System.Windows.Forms.ListBox();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.TeamOneScoreLabel = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.TeamTwoScoreLabel = new System.Windows.Forms.Label();
            this.TeamTwoName = new System.Windows.Forms.Label();
            this.VersusLabel = new System.Windows.Forms.Label();
            this.ScoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Headerlabel
            // 
            this.Headerlabel.AutoSize = true;
            this.Headerlabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F);
            this.Headerlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Headerlabel.Location = new System.Drawing.Point(53, 29);
            this.Headerlabel.Name = "Headerlabel";
            this.Headerlabel.Size = new System.Drawing.Size(214, 50);
            this.Headerlabel.TabIndex = 0;
            this.Headerlabel.Text = "Tournament:";
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F);
            this.TournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentName.Location = new System.Drawing.Point(252, 31);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(150, 50);
            this.TournamentName.TabIndex = 1;
            this.TournamentName.Text = "<none>";
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.RoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RoundLabel.Location = new System.Drawing.Point(55, 81);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(90, 37);
            this.RoundLabel.TabIndex = 2;
            this.RoundLabel.Text = "Round";
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(166, 82);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(268, 36);
            this.RoundDropDown.TabIndex = 3;
            // 
            // UnplayedCheckBox
            // 
            this.UnplayedCheckBox.AutoSize = true;
            this.UnplayedCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.UnplayedCheckBox.Location = new System.Drawing.Point(166, 126);
            this.UnplayedCheckBox.Name = "UnplayedCheckBox";
            this.UnplayedCheckBox.Size = new System.Drawing.Size(164, 32);
            this.UnplayedCheckBox.TabIndex = 4;
            this.UnplayedCheckBox.Text = "Unplayed Only";
            this.UnplayedCheckBox.UseVisualStyleBackColor = true;
            // 
            // MatchupListbox
            // 
            this.MatchupListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MatchupListbox.FormattingEnabled = true;
            this.MatchupListbox.ItemHeight = 28;
            this.MatchupListbox.Location = new System.Drawing.Point(62, 196);
            this.MatchupListbox.Name = "MatchupListbox";
            this.MatchupListbox.Size = new System.Drawing.Size(238, 226);
            this.MatchupListbox.TabIndex = 5;
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.TeamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamOneName.Location = new System.Drawing.Point(329, 180);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(168, 37);
            this.TeamOneName.TabIndex = 6;
            this.TeamOneName.Text = "<Team One>";
            // 
            // TeamOneScoreLabel
            // 
            this.TeamOneScoreLabel.AutoSize = true;
            this.TeamOneScoreLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.TeamOneScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamOneScoreLabel.Location = new System.Drawing.Point(347, 217);
            this.TeamOneScoreLabel.Name = "TeamOneScoreLabel";
            this.TeamOneScoreLabel.Size = new System.Drawing.Size(79, 37);
            this.TeamOneScoreLabel.TabIndex = 7;
            this.TeamOneScoreLabel.Text = "Score";
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.Location = new System.Drawing.Point(460, 217);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(138, 35);
            this.TeamOneScoreValue.TabIndex = 8;
            // 
            // TeamTwoScoreValue
            // 
            this.TeamTwoScoreValue.Location = new System.Drawing.Point(460, 357);
            this.TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            this.TeamTwoScoreValue.Size = new System.Drawing.Size(138, 35);
            this.TeamTwoScoreValue.TabIndex = 11;
            // 
            // TeamTwoScoreLabel
            // 
            this.TeamTwoScoreLabel.AutoSize = true;
            this.TeamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.TeamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamTwoScoreLabel.Location = new System.Drawing.Point(347, 357);
            this.TeamTwoScoreLabel.Name = "TeamTwoScoreLabel";
            this.TeamTwoScoreLabel.Size = new System.Drawing.Size(79, 37);
            this.TeamTwoScoreLabel.TabIndex = 10;
            this.TeamTwoScoreLabel.Text = "Score";
            // 
            // TeamTwoName
            // 
            this.TeamTwoName.AutoSize = true;
            this.TeamTwoName.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.TeamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamTwoName.Location = new System.Drawing.Point(329, 320);
            this.TeamTwoName.Name = "TeamTwoName";
            this.TeamTwoName.Size = new System.Drawing.Size(164, 37);
            this.TeamTwoName.TabIndex = 9;
            this.TeamTwoName.Text = "<Team Two>";
            // 
            // VersusLabel
            // 
            this.VersusLabel.AutoSize = true;
            this.VersusLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.VersusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.VersusLabel.Location = new System.Drawing.Point(429, 270);
            this.VersusLabel.Name = "VersusLabel";
            this.VersusLabel.Size = new System.Drawing.Size(45, 37);
            this.VersusLabel.TabIndex = 12;
            this.VersusLabel.Text = "VS";
            // 
            // ScoreButton
            // 
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ScoreButton.Location = new System.Drawing.Point(523, 270);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(92, 37);
            this.ScoreButton.TabIndex = 13;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 466);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.VersusLabel);
            this.Controls.Add(this.TeamTwoScoreValue);
            this.Controls.Add(this.TeamTwoScoreLabel);
            this.Controls.Add(this.TeamTwoName);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.TeamOneScoreLabel);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.MatchupListbox);
            this.Controls.Add(this.UnplayedCheckBox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.Headerlabel);
            this.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TournamentViewer";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Headerlabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.ComboBox RoundDropDown;
        private System.Windows.Forms.CheckBox UnplayedCheckBox;
        private System.Windows.Forms.ListBox MatchupListbox;
        private System.Windows.Forms.Label TeamOneName;
        private System.Windows.Forms.Label TeamOneScoreLabel;
        private System.Windows.Forms.TextBox TeamOneScoreValue;
        private System.Windows.Forms.TextBox TeamTwoScoreValue;
        private System.Windows.Forms.Label TeamTwoScoreLabel;
        private System.Windows.Forms.Label TeamTwoName;
        private System.Windows.Forms.Label VersusLabel;
        private System.Windows.Forms.Button ScoreButton;
    }
}

