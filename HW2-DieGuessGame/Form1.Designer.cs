namespace HW2_DieGuessGame
{
    partial class DieGuessGame
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EnterGuessLabel = new System.Windows.Forms.Label();
            this.NumberTimesPlayedLabel = new System.Windows.Forms.Label();
            this.NumberTimesWonLabel = new System.Windows.Forms.Label();
            this.NumberTimesLostLabel = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.PlayedCountLabel = new System.Windows.Forms.Label();
            this.WonCountLabel = new System.Windows.Forms.Label();
            this.LostCountLabel = new System.Windows.Forms.Label();
            this.RollButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.UserGuessNumberTextBox = new System.Windows.Forms.RichTextBox();
            this.InvalidNumberLabel = new System.Windows.Forms.Label();
            this.DicePictureBox = new System.Windows.Forms.PictureBox();
            this.ScoreboardBackground = new System.Windows.Forms.TextBox();
            this.GameInfoLabel = new System.Windows.Forms.Label();
            this.DiceNumberLabel = new System.Windows.Forms.Label();
            this.StatsGridView = new System.Windows.Forms.DataGridView();
            this.Face = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Percent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberGuessed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DicePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterGuessLabel
            // 
            this.EnterGuessLabel.AutoSize = true;
            this.EnterGuessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterGuessLabel.Location = new System.Drawing.Point(12, 136);
            this.EnterGuessLabel.Name = "EnterGuessLabel";
            this.EnterGuessLabel.Size = new System.Drawing.Size(178, 17);
            this.EnterGuessLabel.TabIndex = 0;
            this.EnterGuessLabel.Text = "Enter your guess (1-6):";
            // 
            // NumberTimesPlayedLabel
            // 
            this.NumberTimesPlayedLabel.AutoSize = true;
            this.NumberTimesPlayedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberTimesPlayedLabel.Location = new System.Drawing.Point(32, 42);
            this.NumberTimesPlayedLabel.Name = "NumberTimesPlayedLabel";
            this.NumberTimesPlayedLabel.Size = new System.Drawing.Size(195, 17);
            this.NumberTimesPlayedLabel.TabIndex = 2;
            this.NumberTimesPlayedLabel.Text = "Number of Times Played: ";
            // 
            // NumberTimesWonLabel
            // 
            this.NumberTimesWonLabel.AutoSize = true;
            this.NumberTimesWonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberTimesWonLabel.Location = new System.Drawing.Point(33, 68);
            this.NumberTimesWonLabel.Name = "NumberTimesWonLabel";
            this.NumberTimesWonLabel.Size = new System.Drawing.Size(178, 17);
            this.NumberTimesWonLabel.TabIndex = 3;
            this.NumberTimesWonLabel.Text = "Number of Times Won: ";
            // 
            // NumberTimesLostLabel
            // 
            this.NumberTimesLostLabel.AutoSize = true;
            this.NumberTimesLostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberTimesLostLabel.Location = new System.Drawing.Point(34, 94);
            this.NumberTimesLostLabel.Name = "NumberTimesLostLabel";
            this.NumberTimesLostLabel.Size = new System.Drawing.Size(177, 17);
            this.NumberTimesLostLabel.TabIndex = 4;
            this.NumberTimesLostLabel.Text = "Number of Times Lost: ";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // PlayedCountLabel
            // 
            this.PlayedCountLabel.AutoSize = true;
            this.PlayedCountLabel.Location = new System.Drawing.Point(226, 46);
            this.PlayedCountLabel.Name = "PlayedCountLabel";
            this.PlayedCountLabel.Size = new System.Drawing.Size(13, 13);
            this.PlayedCountLabel.TabIndex = 8;
            this.PlayedCountLabel.Text = "0";
            // 
            // WonCountLabel
            // 
            this.WonCountLabel.AutoSize = true;
            this.WonCountLabel.Location = new System.Drawing.Point(226, 72);
            this.WonCountLabel.Name = "WonCountLabel";
            this.WonCountLabel.Size = new System.Drawing.Size(13, 13);
            this.WonCountLabel.TabIndex = 9;
            this.WonCountLabel.Text = "0";
            // 
            // LostCountLabel
            // 
            this.LostCountLabel.AutoSize = true;
            this.LostCountLabel.Location = new System.Drawing.Point(226, 98);
            this.LostCountLabel.Name = "LostCountLabel";
            this.LostCountLabel.Size = new System.Drawing.Size(13, 13);
            this.LostCountLabel.TabIndex = 10;
            this.LostCountLabel.Text = "0";
            // 
            // RollButton
            // 
            this.RollButton.FlatAppearance.BorderSize = 0;
            this.RollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RollButton.ForeColor = System.Drawing.Color.Black;
            this.RollButton.Location = new System.Drawing.Point(196, 189);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(75, 23);
            this.RollButton.TabIndex = 11;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            this.RollButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
            // 
            // ResetButton
            // 
            this.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.ForeColor = System.Drawing.Color.Black;
            this.ResetButton.Location = new System.Drawing.Point(196, 235);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 12;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            this.ResetButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
            // 
            // UserGuessNumberTextBox
            // 
            this.UserGuessNumberTextBox.Location = new System.Drawing.Point(196, 136);
            this.UserGuessNumberTextBox.MaxLength = 1;
            this.UserGuessNumberTextBox.Name = "UserGuessNumberTextBox";
            this.UserGuessNumberTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.UserGuessNumberTextBox.Size = new System.Drawing.Size(45, 20);
            this.UserGuessNumberTextBox.TabIndex = 13;
            this.UserGuessNumberTextBox.Text = "";
            this.UserGuessNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserGuessNumberTextBox_Enter);
            // 
            // InvalidNumberLabel
            // 
            this.InvalidNumberLabel.AutoSize = true;
            this.InvalidNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.InvalidNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.InvalidNumberLabel.Location = new System.Drawing.Point(247, 138);
            this.InvalidNumberLabel.Name = "InvalidNumberLabel";
            this.InvalidNumberLabel.Size = new System.Drawing.Size(82, 13);
            this.InvalidNumberLabel.TabIndex = 14;
            this.InvalidNumberLabel.Text = "*Invalid Number";
            this.InvalidNumberLabel.UseMnemonic = false;
            this.InvalidNumberLabel.Visible = false;
            // 
            // DicePictureBox
            // 
            this.DicePictureBox.InitialImage = null;
            this.DicePictureBox.Location = new System.Drawing.Point(37, 177);
            this.DicePictureBox.Name = "DicePictureBox";
            this.DicePictureBox.Size = new System.Drawing.Size(120, 108);
            this.DicePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DicePictureBox.TabIndex = 15;
            this.DicePictureBox.TabStop = false;
            // 
            // ScoreboardBackground
            // 
            this.ScoreboardBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(215)))));
            this.ScoreboardBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScoreboardBackground.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ScoreboardBackground.Enabled = false;
            this.ScoreboardBackground.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ScoreboardBackground.Location = new System.Drawing.Point(15, 29);
            this.ScoreboardBackground.Multiline = true;
            this.ScoreboardBackground.Name = "ScoreboardBackground";
            this.ScoreboardBackground.ReadOnly = true;
            this.ScoreboardBackground.Size = new System.Drawing.Size(256, 92);
            this.ScoreboardBackground.TabIndex = 16;
            // 
            // GameInfoLabel
            // 
            this.GameInfoLabel.AutoSize = true;
            this.GameInfoLabel.Location = new System.Drawing.Point(23, 23);
            this.GameInfoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.GameInfoLabel.Name = "GameInfoLabel";
            this.GameInfoLabel.Size = new System.Drawing.Size(56, 13);
            this.GameInfoLabel.TabIndex = 17;
            this.GameInfoLabel.Text = "Game Info";
            // 
            // DiceNumberLabel
            // 
            this.DiceNumberLabel.AutoSize = true;
            this.DiceNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiceNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.DiceNumberLabel.Location = new System.Drawing.Point(89, 288);
            this.DiceNumberLabel.Name = "DiceNumberLabel";
            this.DiceNumberLabel.Size = new System.Drawing.Size(0, 24);
            this.DiceNumberLabel.TabIndex = 18;
            // 
            // StatsGridView
            // 
            this.StatsGridView.AllowUserToAddRows = false;
            this.StatsGridView.AllowUserToDeleteRows = false;
            this.StatsGridView.AllowUserToResizeColumns = false;
            this.StatsGridView.AllowUserToResizeRows = false;
            this.StatsGridView.BackgroundColor = System.Drawing.Color.White;
            this.StatsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.StatsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StatsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StatsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Face,
            this.Frequency,
            this.Percent,
            this.NumberGuessed});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StatsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.StatsGridView.EnableHeadersVisualStyles = false;
            this.StatsGridView.GridColor = System.Drawing.Color.IndianRed;
            this.StatsGridView.Location = new System.Drawing.Point(12, 322);
            this.StatsGridView.MultiSelect = false;
            this.StatsGridView.Name = "StatsGridView";
            this.StatsGridView.ReadOnly = true;
            this.StatsGridView.RowHeadersVisible = false;
            this.StatsGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.StatsGridView.RowTemplate.Height = 17;
            this.StatsGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.StatsGridView.ShowCellErrors = false;
            this.StatsGridView.ShowCellToolTips = false;
            this.StatsGridView.ShowEditingIcon = false;
            this.StatsGridView.ShowRowErrors = false;
            this.StatsGridView.Size = new System.Drawing.Size(412, 150);
            this.StatsGridView.TabIndex = 20;
            // 
            // Face
            // 
            this.Face.FillWeight = 58.53659F;
            this.Face.HeaderText = "FACE";
            this.Face.Name = "Face";
            this.Face.ReadOnly = true;
            this.Face.Width = 60;
            // 
            // Frequency
            // 
            this.Frequency.FillWeight = 80.04152F;
            this.Frequency.HeaderText = "FREQUENCY";
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            this.Frequency.Width = 82;
            // 
            // Percent
            // 
            this.Percent.FillWeight = 77.82369F;
            this.Percent.HeaderText = "PERCENT";
            this.Percent.Name = "Percent";
            this.Percent.ReadOnly = true;
            this.Percent.Width = 88;
            // 
            // NumberGuessed
            // 
            this.NumberGuessed.FillWeight = 183.5982F;
            this.NumberGuessed.HeaderText = "NUMBER OF TIMES GUESSED";
            this.NumberGuessed.Name = "NumberGuessed";
            this.NumberGuessed.ReadOnly = true;
            this.NumberGuessed.Width = 185;
            // 
            // DieGuessGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(215)))));
            this.ClientSize = new System.Drawing.Size(436, 484);
            this.Controls.Add(this.StatsGridView);
            this.Controls.Add(this.DiceNumberLabel);
            this.Controls.Add(this.GameInfoLabel);
            this.Controls.Add(this.DicePictureBox);
            this.Controls.Add(this.InvalidNumberLabel);
            this.Controls.Add(this.UserGuessNumberTextBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.LostCountLabel);
            this.Controls.Add(this.WonCountLabel);
            this.Controls.Add(this.PlayedCountLabel);
            this.Controls.Add(this.NumberTimesLostLabel);
            this.Controls.Add(this.NumberTimesWonLabel);
            this.Controls.Add(this.NumberTimesPlayedLabel);
            this.Controls.Add(this.EnterGuessLabel);
            this.Controls.Add(this.ScoreboardBackground);
            this.Name = "DieGuessGame";
            this.Text = "Die Guess Game";
            ((System.ComponentModel.ISupportInitialize)(this.DicePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterGuessLabel;
        private System.Windows.Forms.Label NumberTimesPlayedLabel;
        private System.Windows.Forms.Label NumberTimesWonLabel;
        private System.Windows.Forms.Label NumberTimesLostLabel;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label PlayedCountLabel;
        private System.Windows.Forms.Label WonCountLabel;
        private System.Windows.Forms.Label LostCountLabel;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.RichTextBox UserGuessNumberTextBox;
        private System.Windows.Forms.Label InvalidNumberLabel;
        private System.Windows.Forms.PictureBox DicePictureBox;
        private System.Windows.Forms.TextBox ScoreboardBackground;
        private System.Windows.Forms.Label GameInfoLabel;
        private System.Windows.Forms.Label DiceNumberLabel;
        private System.Windows.Forms.DataGridView StatsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Face;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Percent;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberGuessed;
    }
}

