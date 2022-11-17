namespace TrackerUI
{
    partial class TournamentDashBoardForm
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
            this.TournamentDashboardHeader = new System.Windows.Forms.Label();
            this.loadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.LoadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.LoadTournamentButton = new System.Windows.Forms.Button();
            this.CreateTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentDashboardHeader
            // 
            this.TournamentDashboardHeader.AutoSize = true;
            this.TournamentDashboardHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F);
            this.TournamentDashboardHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentDashboardHeader.Location = new System.Drawing.Point(57, 33);
            this.TournamentDashboardHeader.Name = "TournamentDashboardHeader";
            this.TournamentDashboardHeader.Size = new System.Drawing.Size(385, 50);
            this.TournamentDashboardHeader.TabIndex = 12;
            this.TournamentDashboardHeader.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentDropDown
            // 
            this.loadExistingTournamentDropDown.FormattingEnabled = true;
            this.loadExistingTournamentDropDown.Location = new System.Drawing.Point(94, 139);
            this.loadExistingTournamentDropDown.Name = "loadExistingTournamentDropDown";
            this.loadExistingTournamentDropDown.Size = new System.Drawing.Size(310, 38);
            this.loadExistingTournamentDropDown.TabIndex = 19;
            // 
            // LoadExistingTournamentLabel
            // 
            this.LoadExistingTournamentLabel.AutoSize = true;
            this.LoadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.LoadExistingTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LoadExistingTournamentLabel.Location = new System.Drawing.Point(98, 99);
            this.LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            this.LoadExistingTournamentLabel.Size = new System.Drawing.Size(303, 37);
            this.LoadExistingTournamentLabel.TabIndex = 18;
            this.LoadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // LoadTournamentButton
            // 
            this.LoadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LoadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LoadTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LoadTournamentButton.Location = new System.Drawing.Point(146, 183);
            this.LoadTournamentButton.Name = "LoadTournamentButton";
            this.LoadTournamentButton.Size = new System.Drawing.Size(198, 37);
            this.LoadTournamentButton.TabIndex = 26;
            this.LoadTournamentButton.Text = "Load Tournament";
            this.LoadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentButton
            // 
            this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentButton.Location = new System.Drawing.Point(146, 243);
            this.CreateTournamentButton.Name = "CreateTournamentButton";
            this.CreateTournamentButton.Size = new System.Drawing.Size(198, 53);
            this.CreateTournamentButton.TabIndex = 27;
            this.CreateTournamentButton.Text = "Create Tournament";
            this.CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 403);
            this.Controls.Add(this.CreateTournamentButton);
            this.Controls.Add(this.LoadTournamentButton);
            this.Controls.Add(this.loadExistingTournamentDropDown);
            this.Controls.Add(this.LoadExistingTournamentLabel);
            this.Controls.Add(this.TournamentDashboardHeader);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashBoardForm";
            this.Text = "Tournament DashBoard ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentDashboardHeader;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropDown;
        private System.Windows.Forms.Label LoadExistingTournamentLabel;
        private System.Windows.Forms.Button LoadTournamentButton;
        private System.Windows.Forms.Button CreateTournamentButton;
    }
}