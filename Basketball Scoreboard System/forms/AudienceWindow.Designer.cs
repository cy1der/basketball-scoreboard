namespace Basketball_Scoreboard_System.forms
{
    partial class AudienceWindow
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
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelParent = new Panel();
            LabelHomeTeamFouls = new Label();
            LabelHomeTeamFoulsTitle = new Label();
            LabelAwayTeamFouls = new Label();
            LabelAwayTeamFoulsTitle = new Label();
            LabelHomeTeamBonus = new Label();
            LabelAwayTeamBonus = new Label();
            LabelAwayTeamPossession = new Label();
            LabelHomeTeamPossession = new Label();
            LabelPeriod = new Label();
            LabelPeriodTitle = new Label();
            LabelAwayScore = new Label();
            LabelHomeScore = new Label();
            LabelShotClockTitle = new Label();
            LabelShotClock = new Label();
            PanelScoreAway = new Panel();
            LabelAwayTeamName = new Label();
            PanelScoreHome = new Panel();
            LabelHomeTeamName = new Label();
            LabelClock = new Label();
            MainClockTimer = new System.Timers.Timer();
            ShotClockTimer = new System.Timers.Timer();
            PanelParent.SuspendLayout();
            PanelScoreAway.SuspendLayout();
            PanelScoreHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainClockTimer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShotClockTimer).BeginInit();
            SuspendLayout();
            // 
            // PanelParent
            // 
            PanelParent.Anchor = AnchorStyles.None;
            PanelParent.Controls.Add(LabelHomeTeamFouls);
            PanelParent.Controls.Add(LabelHomeTeamFoulsTitle);
            PanelParent.Controls.Add(LabelAwayTeamFouls);
            PanelParent.Controls.Add(LabelAwayTeamFoulsTitle);
            PanelParent.Controls.Add(LabelHomeTeamBonus);
            PanelParent.Controls.Add(LabelAwayTeamBonus);
            PanelParent.Controls.Add(LabelAwayTeamPossession);
            PanelParent.Controls.Add(LabelHomeTeamPossession);
            PanelParent.Controls.Add(LabelPeriod);
            PanelParent.Controls.Add(LabelPeriodTitle);
            PanelParent.Controls.Add(LabelAwayScore);
            PanelParent.Controls.Add(LabelHomeScore);
            PanelParent.Controls.Add(LabelShotClockTitle);
            PanelParent.Controls.Add(LabelShotClock);
            PanelParent.Controls.Add(PanelScoreAway);
            PanelParent.Controls.Add(PanelScoreHome);
            PanelParent.Controls.Add(LabelClock);
            PanelParent.Location = new Point(12, 12);
            PanelParent.Margin = new Padding(8);
            PanelParent.Name = "PanelParent";
            PanelParent.Size = new Size(1410, 752);
            PanelParent.TabIndex = 0;
            // 
            // LabelHomeTeamFouls
            // 
            LabelHomeTeamFouls.BackColor = Color.Transparent;
            LabelHomeTeamFouls.Font = new Font("DSEG7 Classic", 72F, FontStyle.Regular, GraphicsUnit.Point);
            LabelHomeTeamFouls.ForeColor = Color.FromArgb(255, 128, 128);
            LabelHomeTeamFouls.Location = new Point(192, 512);
            LabelHomeTeamFouls.Name = "LabelHomeTeamFouls";
            LabelHomeTeamFouls.Size = new Size(108, 154);
            LabelHomeTeamFouls.TabIndex = 15;
            LabelHomeTeamFouls.Text = "-";
            LabelHomeTeamFouls.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelHomeTeamFoulsTitle
            // 
            LabelHomeTeamFoulsTitle.Font = new Font("Fira Mono", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHomeTeamFoulsTitle.Location = new Point(154, 460);
            LabelHomeTeamFoulsTitle.Name = "LabelHomeTeamFoulsTitle";
            LabelHomeTeamFoulsTitle.Size = new Size(185, 52);
            LabelHomeTeamFoulsTitle.TabIndex = 14;
            LabelHomeTeamFoulsTitle.Text = "FOULS";
            LabelHomeTeamFoulsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelAwayTeamFouls
            // 
            LabelAwayTeamFouls.BackColor = Color.Transparent;
            LabelAwayTeamFouls.Font = new Font("DSEG7 Classic", 72F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAwayTeamFouls.ForeColor = Color.FromArgb(255, 128, 128);
            LabelAwayTeamFouls.Location = new Point(1109, 512);
            LabelAwayTeamFouls.Name = "LabelAwayTeamFouls";
            LabelAwayTeamFouls.Size = new Size(108, 154);
            LabelAwayTeamFouls.TabIndex = 13;
            LabelAwayTeamFouls.Text = "-";
            LabelAwayTeamFouls.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelAwayTeamFoulsTitle
            // 
            LabelAwayTeamFoulsTitle.Font = new Font("Fira Mono", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAwayTeamFoulsTitle.Location = new Point(1071, 460);
            LabelAwayTeamFoulsTitle.Name = "LabelAwayTeamFoulsTitle";
            LabelAwayTeamFoulsTitle.Size = new Size(185, 52);
            LabelAwayTeamFoulsTitle.TabIndex = 12;
            LabelAwayTeamFoulsTitle.Text = "FOULS";
            LabelAwayTeamFoulsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelHomeTeamBonus
            // 
            LabelHomeTeamBonus.BackColor = Color.Transparent;
            LabelHomeTeamBonus.Font = new Font("DSEG14 Classic", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point);
            LabelHomeTeamBonus.ForeColor = Color.FromArgb(255, 128, 128);
            LabelHomeTeamBonus.Location = new Point(393, 391);
            LabelHomeTeamBonus.Name = "LabelHomeTeamBonus";
            LabelHomeTeamBonus.Size = new Size(91, 121);
            LabelHomeTeamBonus.TabIndex = 11;
            LabelHomeTeamBonus.Text = "B";
            LabelHomeTeamBonus.TextAlign = ContentAlignment.MiddleCenter;
            LabelHomeTeamBonus.Visible = false;
            // 
            // LabelAwayTeamBonus
            // 
            LabelAwayTeamBonus.BackColor = Color.Transparent;
            LabelAwayTeamBonus.Font = new Font("DSEG14 Classic", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAwayTeamBonus.ForeColor = Color.FromArgb(255, 128, 128);
            LabelAwayTeamBonus.Location = new Point(926, 391);
            LabelAwayTeamBonus.Name = "LabelAwayTeamBonus";
            LabelAwayTeamBonus.Size = new Size(91, 121);
            LabelAwayTeamBonus.TabIndex = 10;
            LabelAwayTeamBonus.Text = "B";
            LabelAwayTeamBonus.TextAlign = ContentAlignment.MiddleCenter;
            LabelAwayTeamBonus.Visible = false;
            // 
            // LabelAwayTeamPossession
            // 
            LabelAwayTeamPossession.BackColor = Color.Transparent;
            LabelAwayTeamPossession.Font = new Font("DSEG14 Classic", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAwayTeamPossession.ForeColor = Color.FromArgb(255, 128, 128);
            LabelAwayTeamPossession.Location = new Point(790, 512);
            LabelAwayTeamPossession.Name = "LabelAwayTeamPossession";
            LabelAwayTeamPossession.Size = new Size(91, 121);
            LabelAwayTeamPossession.TabIndex = 9;
            LabelAwayTeamPossession.Text = ">";
            LabelAwayTeamPossession.TextAlign = ContentAlignment.MiddleCenter;
            LabelAwayTeamPossession.Visible = false;
            // 
            // LabelHomeTeamPossession
            // 
            LabelHomeTeamPossession.BackColor = Color.Transparent;
            LabelHomeTeamPossession.Font = new Font("DSEG14 Classic", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point);
            LabelHomeTeamPossession.ForeColor = Color.FromArgb(255, 128, 128);
            LabelHomeTeamPossession.Location = new Point(529, 512);
            LabelHomeTeamPossession.Name = "LabelHomeTeamPossession";
            LabelHomeTeamPossession.Size = new Size(91, 121);
            LabelHomeTeamPossession.TabIndex = 8;
            LabelHomeTeamPossession.Text = "<";
            LabelHomeTeamPossession.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelPeriod
            // 
            LabelPeriod.BackColor = Color.Transparent;
            LabelPeriod.Font = new Font("DSEG7 Classic", 72F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPeriod.ForeColor = Color.FromArgb(255, 128, 128);
            LabelPeriod.Location = new Point(651, 512);
            LabelPeriod.Name = "LabelPeriod";
            LabelPeriod.Size = new Size(108, 154);
            LabelPeriod.TabIndex = 7;
            LabelPeriod.Text = "-";
            LabelPeriod.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelPeriodTitle
            // 
            LabelPeriodTitle.Font = new Font("Fira Mono", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPeriodTitle.Location = new Point(613, 460);
            LabelPeriodTitle.Name = "LabelPeriodTitle";
            LabelPeriodTitle.Size = new Size(185, 52);
            LabelPeriodTitle.TabIndex = 4;
            LabelPeriodTitle.Text = "PERIOD";
            LabelPeriodTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelAwayScore
            // 
            LabelAwayScore.BackColor = Color.Transparent;
            LabelAwayScore.Font = new Font("DSEG7 Classic", 120F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAwayScore.ForeColor = Color.FromArgb(255, 128, 128);
            LabelAwayScore.Location = new Point(926, 223);
            LabelAwayScore.Name = "LabelAwayScore";
            LabelAwayScore.Size = new Size(475, 160);
            LabelAwayScore.TabIndex = 6;
            LabelAwayScore.Text = "0";
            LabelAwayScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelHomeScore
            // 
            LabelHomeScore.BackColor = Color.Transparent;
            LabelHomeScore.Font = new Font("DSEG7 Classic", 120F, FontStyle.Regular, GraphicsUnit.Point);
            LabelHomeScore.ForeColor = Color.FromArgb(255, 128, 128);
            LabelHomeScore.Location = new Point(9, 223);
            LabelHomeScore.Name = "LabelHomeScore";
            LabelHomeScore.Size = new Size(475, 160);
            LabelHomeScore.TabIndex = 5;
            LabelHomeScore.Text = "0";
            LabelHomeScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelShotClockTitle
            // 
            LabelShotClockTitle.Font = new Font("Fira Mono", 36F, FontStyle.Bold, GraphicsUnit.Point);
            LabelShotClockTitle.Location = new Point(529, 223);
            LabelShotClockTitle.Name = "LabelShotClockTitle";
            LabelShotClockTitle.Size = new Size(352, 77);
            LabelShotClockTitle.TabIndex = 4;
            LabelShotClockTitle.Text = "SHOT CLOCK";
            LabelShotClockTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelShotClock
            // 
            LabelShotClock.BackColor = Color.Transparent;
            LabelShotClock.Font = new Font("DSEG7 Classic", 95.99998F, FontStyle.Regular, GraphicsUnit.Point);
            LabelShotClock.ForeColor = Color.FromArgb(255, 128, 128);
            LabelShotClock.Location = new Point(567, 300);
            LabelShotClock.Name = "LabelShotClock";
            LabelShotClock.Size = new Size(277, 160);
            LabelShotClock.TabIndex = 3;
            LabelShotClock.Text = "--";
            LabelShotClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PanelScoreAway
            // 
            PanelScoreAway.Controls.Add(LabelAwayTeamName);
            PanelScoreAway.Location = new Point(1061, 3);
            PanelScoreAway.Name = "PanelScoreAway";
            PanelScoreAway.Size = new Size(346, 212);
            PanelScoreAway.TabIndex = 2;
            // 
            // LabelAwayTeamName
            // 
            LabelAwayTeamName.AutoSize = true;
            LabelAwayTeamName.Font = new Font("Fira Mono", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAwayTeamName.Location = new Point(0, 0);
            LabelAwayTeamName.MaximumSize = new Size(340, 212);
            LabelAwayTeamName.MinimumSize = new Size(340, 212);
            LabelAwayTeamName.Name = "LabelAwayTeamName";
            LabelAwayTeamName.Size = new Size(340, 212);
            LabelAwayTeamName.TabIndex = 3;
            LabelAwayTeamName.Text = "----";
            LabelAwayTeamName.TextAlign = ContentAlignment.MiddleCenter;
            LabelAwayTeamName.Paint += LabelAwayTeamName_Paint;
            // 
            // PanelScoreHome
            // 
            PanelScoreHome.Controls.Add(LabelHomeTeamName);
            PanelScoreHome.Location = new Point(3, 3);
            PanelScoreHome.Name = "PanelScoreHome";
            PanelScoreHome.Size = new Size(346, 212);
            PanelScoreHome.TabIndex = 1;
            // 
            // LabelHomeTeamName
            // 
            LabelHomeTeamName.AutoSize = true;
            LabelHomeTeamName.Font = new Font("Fira Mono", 32F, FontStyle.Regular, GraphicsUnit.Point);
            LabelHomeTeamName.Location = new Point(6, 0);
            LabelHomeTeamName.MaximumSize = new Size(340, 212);
            LabelHomeTeamName.MinimumSize = new Size(340, 212);
            LabelHomeTeamName.Name = "LabelHomeTeamName";
            LabelHomeTeamName.Size = new Size(340, 212);
            LabelHomeTeamName.TabIndex = 0;
            LabelHomeTeamName.Text = "----";
            LabelHomeTeamName.TextAlign = ContentAlignment.MiddleCenter;
            LabelHomeTeamName.Paint += LabelHomeTeamName_Paint;
            // 
            // LabelClock
            // 
            LabelClock.BackColor = Color.Transparent;
            LabelClock.Font = new Font("DSEG7 Classic", 128F, FontStyle.Regular, GraphicsUnit.Point);
            LabelClock.ForeColor = Color.FromArgb(255, 128, 128);
            LabelClock.Location = new Point(355, 0);
            LabelClock.Name = "LabelClock";
            LabelClock.Size = new Size(700, 215);
            LabelClock.TabIndex = 0;
            LabelClock.Text = "--:--";
            LabelClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainClockTimer
            // 
            MainClockTimer.Interval = 25D;
            MainClockTimer.SynchronizingObject = this;
            MainClockTimer.Elapsed += MainClockTimer_Elapsed;
            // 
            // ShotClockTimer
            // 
            ShotClockTimer.Interval = 1000D;
            ShotClockTimer.SynchronizingObject = this;
            ShotClockTimer.Elapsed += ShotClockTimer_Elapsed;
            // 
            // AudienceWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1434, 776);
            Controls.Add(PanelParent);
            ForeColor = Color.White;
            MinimumSize = new Size(1450, 815);
            Name = "AudienceWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audience Window";
            FormClosing += AudienceWindow_FormClosing;
            Load += AudienceWindow_Load;
            PanelParent.ResumeLayout(false);
            PanelScoreAway.ResumeLayout(false);
            PanelScoreAway.PerformLayout();
            PanelScoreHome.ResumeLayout(false);
            PanelScoreHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MainClockTimer).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShotClockTimer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelParent;
        private Panel PanelScoreAway;
        private Panel PanelScoreHome;
        public Label LabelHomeTeamName;
        public Label LabelAwayTeamName;
        public System.Timers.Timer MainClockTimer;
        public Label LabelClock;
        public System.Timers.Timer ShotClockTimer;
        public Label LabelShotClock;
        public Label LabelShotClockTitle;
        public Label LabelHomeScore;
        public Label LabelAwayScore;
        public Label LabelPeriodTitle;
        public Label LabelPeriod;
        public Label LabelAwayTeamPossession;
        public Label LabelHomeTeamPossession;
        public Label LabelHomeTeamBonus;
        public Label LabelAwayTeamBonus;
        public Label LabelAwayTeamFouls;
        public Label LabelAwayTeamFoulsTitle;
        public Label LabelHomeTeamFouls;
        public Label LabelHomeTeamFoulsTitle;
    }
}