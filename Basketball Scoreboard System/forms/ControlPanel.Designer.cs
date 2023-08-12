namespace Basketball_Scoreboard_System.forms
{
    partial class ControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            ControlPanelMenuStrip = new MenuStrip();
            GameMenu = new ToolStripMenuItem();
            GameMenuSetPeriod = new ToolStripMenuItem();
            GameMenuSwitchPossession = new ToolStripMenuItem();
            TeamsMenu = new ToolStripMenuItem();
            TeamsMenuHome = new ToolStripMenuItem();
            TeamsMenuHomeChangeName = new ToolStripMenuItem();
            TeamsMenuHomeSetFouls = new ToolStripMenuItem();
            TeamsMenuAway = new ToolStripMenuItem();
            TeamsMenuAwayChangeName = new ToolStripMenuItem();
            TeamsMenuAwaySetFouls = new ToolStripMenuItem();
            SetBonusFoulThresholdMenuButton = new ToolStripMenuItem();
            MainClockMenu = new ToolStripMenuItem();
            MainClockMenuSetTime = new ToolStripMenuItem();
            MainClockMenuSetDefaultTime = new ToolStripMenuItem();
            ShotClockMenu = new ToolStripMenuItem();
            ShotClockMenuSetTime = new ToolStripMenuItem();
            ShotClockMenuSetDefaultTime = new ToolStripMenuItem();
            ShotClockMenuToggleShotClock = new ToolStripMenuItem();
            ButtonStartClocks = new Button();
            ButtonStopClocks = new Button();
            ButtonSCSetToDefault = new Button();
            ButtonSCSet14S = new Button();
            LabelHomeTitle = new Label();
            LabelAwayTitle = new Label();
            Line = new Label();
            ButtonHomeScoreAdd1 = new Button();
            ButtonHomeScoreAdd2 = new Button();
            ButtonHomeScoreAdd3 = new Button();
            ButtonHomeScoreSubtract1 = new Button();
            ButtonHomeScoreSubtract2 = new Button();
            ButtonHomeScoreSubtract3 = new Button();
            ButtonAwayScoreAdd1 = new Button();
            ButtonAwayScoreAdd2 = new Button();
            ButtonAwayScoreSubtract1 = new Button();
            ButtonAwayScoreSubtract2 = new Button();
            ButtonAwayScoreAdd3 = new Button();
            ButtonAwayScoreSubtract3 = new Button();
            LabelClock = new Label();
            LabelShotClock = new Label();
            LabelPeriod = new Label();
            LabelAwayPossession = new Label();
            LabelHomePossession = new Label();
            LabelAwayBonus = new Label();
            LabelHomeBonus = new Label();
            LabelAwayFouls = new Label();
            LabelAwayScore = new Label();
            LabelHomeFouls = new Label();
            LabelHomeScore = new Label();
            ControlPanelMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ControlPanelMenuStrip
            // 
            ControlPanelMenuStrip.Items.AddRange(new ToolStripItem[] { GameMenu, TeamsMenu, MainClockMenu, ShotClockMenu });
            resources.ApplyResources(ControlPanelMenuStrip, "ControlPanelMenuStrip");
            ControlPanelMenuStrip.Name = "ControlPanelMenuStrip";
            ControlPanelMenuStrip.RenderMode = ToolStripRenderMode.System;
            // 
            // GameMenu
            // 
            GameMenu.DropDownItems.AddRange(new ToolStripItem[] { GameMenuSetPeriod, GameMenuSwitchPossession });
            GameMenu.Name = "GameMenu";
            resources.ApplyResources(GameMenu, "GameMenu");
            // 
            // GameMenuSetPeriod
            // 
            GameMenuSetPeriod.Name = "GameMenuSetPeriod";
            resources.ApplyResources(GameMenuSetPeriod, "GameMenuSetPeriod");
            GameMenuSetPeriod.Click += GameMenuSetPeriod_Click;
            // 
            // GameMenuSwitchPossession
            // 
            GameMenuSwitchPossession.Name = "GameMenuSwitchPossession";
            resources.ApplyResources(GameMenuSwitchPossession, "GameMenuSwitchPossession");
            GameMenuSwitchPossession.Click += GameMenuSwitchPossession_Click;
            // 
            // TeamsMenu
            // 
            TeamsMenu.DropDownItems.AddRange(new ToolStripItem[] { TeamsMenuHome, TeamsMenuAway, SetBonusFoulThresholdMenuButton });
            TeamsMenu.Name = "TeamsMenu";
            resources.ApplyResources(TeamsMenu, "TeamsMenu");
            // 
            // TeamsMenuHome
            // 
            TeamsMenuHome.DropDownItems.AddRange(new ToolStripItem[] { TeamsMenuHomeChangeName, TeamsMenuHomeSetFouls });
            TeamsMenuHome.Name = "TeamsMenuHome";
            resources.ApplyResources(TeamsMenuHome, "TeamsMenuHome");
            // 
            // TeamsMenuHomeChangeName
            // 
            TeamsMenuHomeChangeName.Name = "TeamsMenuHomeChangeName";
            resources.ApplyResources(TeamsMenuHomeChangeName, "TeamsMenuHomeChangeName");
            TeamsMenuHomeChangeName.Click += TeamsMenuHomeChangeName_Click;
            // 
            // TeamsMenuHomeSetFouls
            // 
            TeamsMenuHomeSetFouls.Name = "TeamsMenuHomeSetFouls";
            resources.ApplyResources(TeamsMenuHomeSetFouls, "TeamsMenuHomeSetFouls");
            TeamsMenuHomeSetFouls.Click += TeamsMenuHomeSetFouls_Click;
            // 
            // TeamsMenuAway
            // 
            TeamsMenuAway.DropDownItems.AddRange(new ToolStripItem[] { TeamsMenuAwayChangeName, TeamsMenuAwaySetFouls });
            TeamsMenuAway.Name = "TeamsMenuAway";
            resources.ApplyResources(TeamsMenuAway, "TeamsMenuAway");
            // 
            // TeamsMenuAwayChangeName
            // 
            TeamsMenuAwayChangeName.Name = "TeamsMenuAwayChangeName";
            resources.ApplyResources(TeamsMenuAwayChangeName, "TeamsMenuAwayChangeName");
            TeamsMenuAwayChangeName.Click += TeamsMenuAwayChangeName_Click;
            // 
            // TeamsMenuAwaySetFouls
            // 
            TeamsMenuAwaySetFouls.Name = "TeamsMenuAwaySetFouls";
            resources.ApplyResources(TeamsMenuAwaySetFouls, "TeamsMenuAwaySetFouls");
            TeamsMenuAwaySetFouls.Click += TeamsMenuAwaySetFouls_Click;
            // 
            // SetBonusFoulThresholdMenuButton
            // 
            SetBonusFoulThresholdMenuButton.Name = "SetBonusFoulThresholdMenuButton";
            resources.ApplyResources(SetBonusFoulThresholdMenuButton, "SetBonusFoulThresholdMenuButton");
            SetBonusFoulThresholdMenuButton.Click += SetBonusFoulThresholdMenuButton_Click;
            // 
            // MainClockMenu
            // 
            MainClockMenu.DropDownItems.AddRange(new ToolStripItem[] { MainClockMenuSetTime, MainClockMenuSetDefaultTime });
            MainClockMenu.Name = "MainClockMenu";
            resources.ApplyResources(MainClockMenu, "MainClockMenu");
            // 
            // MainClockMenuSetTime
            // 
            MainClockMenuSetTime.Name = "MainClockMenuSetTime";
            resources.ApplyResources(MainClockMenuSetTime, "MainClockMenuSetTime");
            MainClockMenuSetTime.Click += MainClockMenuSetTime_Click;
            // 
            // MainClockMenuSetDefaultTime
            // 
            MainClockMenuSetDefaultTime.Name = "MainClockMenuSetDefaultTime";
            resources.ApplyResources(MainClockMenuSetDefaultTime, "MainClockMenuSetDefaultTime");
            MainClockMenuSetDefaultTime.Click += MainClockMenuSetDefaultTime_Click;
            // 
            // ShotClockMenu
            // 
            ShotClockMenu.DropDownItems.AddRange(new ToolStripItem[] { ShotClockMenuSetTime, ShotClockMenuSetDefaultTime, ShotClockMenuToggleShotClock });
            ShotClockMenu.Name = "ShotClockMenu";
            resources.ApplyResources(ShotClockMenu, "ShotClockMenu");
            // 
            // ShotClockMenuSetTime
            // 
            ShotClockMenuSetTime.Name = "ShotClockMenuSetTime";
            resources.ApplyResources(ShotClockMenuSetTime, "ShotClockMenuSetTime");
            ShotClockMenuSetTime.Click += ShotClockMenuSetTime_Click;
            // 
            // ShotClockMenuSetDefaultTime
            // 
            ShotClockMenuSetDefaultTime.Name = "ShotClockMenuSetDefaultTime";
            resources.ApplyResources(ShotClockMenuSetDefaultTime, "ShotClockMenuSetDefaultTime");
            ShotClockMenuSetDefaultTime.Click += ShotClockMenuSetDefaultTime_Click;
            // 
            // ShotClockMenuToggleShotClock
            // 
            ShotClockMenuToggleShotClock.Name = "ShotClockMenuToggleShotClock";
            resources.ApplyResources(ShotClockMenuToggleShotClock, "ShotClockMenuToggleShotClock");
            ShotClockMenuToggleShotClock.Click += ShotClockMenuToggleShotClock_Click;
            // 
            // ButtonStartClocks
            // 
            ButtonStartClocks.BackColor = Color.FromArgb(192, 255, 192);
            resources.ApplyResources(ButtonStartClocks, "ButtonStartClocks");
            ButtonStartClocks.Name = "ButtonStartClocks";
            ButtonStartClocks.UseVisualStyleBackColor = false;
            ButtonStartClocks.Click += ButtonStartClocks_Click;
            // 
            // ButtonStopClocks
            // 
            ButtonStopClocks.BackColor = Color.FromArgb(255, 192, 192);
            resources.ApplyResources(ButtonStopClocks, "ButtonStopClocks");
            ButtonStopClocks.Name = "ButtonStopClocks";
            ButtonStopClocks.UseVisualStyleBackColor = false;
            ButtonStopClocks.Click += ButtonStopClocks_Click;
            // 
            // ButtonSCSetToDefault
            // 
            resources.ApplyResources(ButtonSCSetToDefault, "ButtonSCSetToDefault");
            ButtonSCSetToDefault.Name = "ButtonSCSetToDefault";
            ButtonSCSetToDefault.UseVisualStyleBackColor = true;
            ButtonSCSetToDefault.Click += ButtonSCSetToDefault_Click;
            // 
            // ButtonSCSet14S
            // 
            resources.ApplyResources(ButtonSCSet14S, "ButtonSCSet14S");
            ButtonSCSet14S.Name = "ButtonSCSet14S";
            ButtonSCSet14S.UseVisualStyleBackColor = true;
            ButtonSCSet14S.Click += ButtonSCSet14S_Click;
            // 
            // LabelHomeTitle
            // 
            resources.ApplyResources(LabelHomeTitle, "LabelHomeTitle");
            LabelHomeTitle.Name = "LabelHomeTitle";
            // 
            // LabelAwayTitle
            // 
            resources.ApplyResources(LabelAwayTitle, "LabelAwayTitle");
            LabelAwayTitle.Name = "LabelAwayTitle";
            // 
            // Line
            // 
            Line.BorderStyle = BorderStyle.Fixed3D;
            resources.ApplyResources(Line, "Line");
            Line.Name = "Line";
            // 
            // ButtonHomeScoreAdd1
            // 
            resources.ApplyResources(ButtonHomeScoreAdd1, "ButtonHomeScoreAdd1");
            ButtonHomeScoreAdd1.Name = "ButtonHomeScoreAdd1";
            ButtonHomeScoreAdd1.UseVisualStyleBackColor = true;
            ButtonHomeScoreAdd1.Click += ButtonHomeScoreAdd1_Click;
            // 
            // ButtonHomeScoreAdd2
            // 
            resources.ApplyResources(ButtonHomeScoreAdd2, "ButtonHomeScoreAdd2");
            ButtonHomeScoreAdd2.Name = "ButtonHomeScoreAdd2";
            ButtonHomeScoreAdd2.UseVisualStyleBackColor = true;
            ButtonHomeScoreAdd2.Click += ButtonHomeScoreAdd2_Click;
            // 
            // ButtonHomeScoreAdd3
            // 
            resources.ApplyResources(ButtonHomeScoreAdd3, "ButtonHomeScoreAdd3");
            ButtonHomeScoreAdd3.Name = "ButtonHomeScoreAdd3";
            ButtonHomeScoreAdd3.UseVisualStyleBackColor = true;
            ButtonHomeScoreAdd3.Click += ButtonHomeScoreAdd3_Click;
            // 
            // ButtonHomeScoreSubtract1
            // 
            resources.ApplyResources(ButtonHomeScoreSubtract1, "ButtonHomeScoreSubtract1");
            ButtonHomeScoreSubtract1.Name = "ButtonHomeScoreSubtract1";
            ButtonHomeScoreSubtract1.UseVisualStyleBackColor = true;
            ButtonHomeScoreSubtract1.Click += ButtonHomeScoreSubtract1_Click;
            // 
            // ButtonHomeScoreSubtract2
            // 
            resources.ApplyResources(ButtonHomeScoreSubtract2, "ButtonHomeScoreSubtract2");
            ButtonHomeScoreSubtract2.Name = "ButtonHomeScoreSubtract2";
            ButtonHomeScoreSubtract2.UseVisualStyleBackColor = true;
            ButtonHomeScoreSubtract2.Click += ButtonHomeScoreSubtract2_Click;
            // 
            // ButtonHomeScoreSubtract3
            // 
            resources.ApplyResources(ButtonHomeScoreSubtract3, "ButtonHomeScoreSubtract3");
            ButtonHomeScoreSubtract3.Name = "ButtonHomeScoreSubtract3";
            ButtonHomeScoreSubtract3.UseVisualStyleBackColor = true;
            ButtonHomeScoreSubtract3.Click += ButtonHomeScoreSubtract3_Click;
            // 
            // ButtonAwayScoreAdd1
            // 
            resources.ApplyResources(ButtonAwayScoreAdd1, "ButtonAwayScoreAdd1");
            ButtonAwayScoreAdd1.Name = "ButtonAwayScoreAdd1";
            ButtonAwayScoreAdd1.UseVisualStyleBackColor = true;
            ButtonAwayScoreAdd1.Click += ButtonAwayScoreAdd1_Click;
            // 
            // ButtonAwayScoreAdd2
            // 
            resources.ApplyResources(ButtonAwayScoreAdd2, "ButtonAwayScoreAdd2");
            ButtonAwayScoreAdd2.Name = "ButtonAwayScoreAdd2";
            ButtonAwayScoreAdd2.UseVisualStyleBackColor = true;
            ButtonAwayScoreAdd2.Click += ButtonAwayScoreAdd2_Click;
            // 
            // ButtonAwayScoreSubtract1
            // 
            resources.ApplyResources(ButtonAwayScoreSubtract1, "ButtonAwayScoreSubtract1");
            ButtonAwayScoreSubtract1.Name = "ButtonAwayScoreSubtract1";
            ButtonAwayScoreSubtract1.UseVisualStyleBackColor = true;
            ButtonAwayScoreSubtract1.Click += ButtonAwayScoreSubtract1_Click;
            // 
            // ButtonAwayScoreSubtract2
            // 
            resources.ApplyResources(ButtonAwayScoreSubtract2, "ButtonAwayScoreSubtract2");
            ButtonAwayScoreSubtract2.Name = "ButtonAwayScoreSubtract2";
            ButtonAwayScoreSubtract2.UseVisualStyleBackColor = true;
            ButtonAwayScoreSubtract2.Click += ButtonAwayScoreSubtract2_Click;
            // 
            // ButtonAwayScoreAdd3
            // 
            resources.ApplyResources(ButtonAwayScoreAdd3, "ButtonAwayScoreAdd3");
            ButtonAwayScoreAdd3.Name = "ButtonAwayScoreAdd3";
            ButtonAwayScoreAdd3.UseVisualStyleBackColor = true;
            ButtonAwayScoreAdd3.Click += ButtonAwayScoreAdd3_Click;
            // 
            // ButtonAwayScoreSubtract3
            // 
            resources.ApplyResources(ButtonAwayScoreSubtract3, "ButtonAwayScoreSubtract3");
            ButtonAwayScoreSubtract3.Name = "ButtonAwayScoreSubtract3";
            ButtonAwayScoreSubtract3.UseVisualStyleBackColor = true;
            ButtonAwayScoreSubtract3.Click += ButtonAwayScoreSubtract3_Click;
            // 
            // LabelClock
            // 
            resources.ApplyResources(LabelClock, "LabelClock");
            LabelClock.Name = "LabelClock";
            // 
            // LabelShotClock
            // 
            resources.ApplyResources(LabelShotClock, "LabelShotClock");
            LabelShotClock.Name = "LabelShotClock";
            // 
            // LabelPeriod
            // 
            resources.ApplyResources(LabelPeriod, "LabelPeriod");
            LabelPeriod.Name = "LabelPeriod";
            // 
            // LabelAwayPossession
            // 
            resources.ApplyResources(LabelAwayPossession, "LabelAwayPossession");
            LabelAwayPossession.Name = "LabelAwayPossession";
            // 
            // LabelHomePossession
            // 
            resources.ApplyResources(LabelHomePossession, "LabelHomePossession");
            LabelHomePossession.Name = "LabelHomePossession";
            // 
            // LabelAwayBonus
            // 
            resources.ApplyResources(LabelAwayBonus, "LabelAwayBonus");
            LabelAwayBonus.Name = "LabelAwayBonus";
            // 
            // LabelHomeBonus
            // 
            resources.ApplyResources(LabelHomeBonus, "LabelHomeBonus");
            LabelHomeBonus.Name = "LabelHomeBonus";
            // 
            // LabelAwayFouls
            // 
            resources.ApplyResources(LabelAwayFouls, "LabelAwayFouls");
            LabelAwayFouls.Name = "LabelAwayFouls";
            // 
            // LabelAwayScore
            // 
            resources.ApplyResources(LabelAwayScore, "LabelAwayScore");
            LabelAwayScore.Name = "LabelAwayScore";
            // 
            // LabelHomeFouls
            // 
            resources.ApplyResources(LabelHomeFouls, "LabelHomeFouls");
            LabelHomeFouls.Name = "LabelHomeFouls";
            // 
            // LabelHomeScore
            // 
            resources.ApplyResources(LabelHomeScore, "LabelHomeScore");
            LabelHomeScore.Name = "LabelHomeScore";
            // 
            // ControlPanel
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(LabelHomeBonus);
            Controls.Add(LabelHomeScore);
            Controls.Add(LabelAwayScore);
            Controls.Add(LabelAwayBonus);
            Controls.Add(LabelHomePossession);
            Controls.Add(LabelHomeFouls);
            Controls.Add(LabelAwayFouls);
            Controls.Add(LabelAwayPossession);
            Controls.Add(LabelPeriod);
            Controls.Add(LabelShotClock);
            Controls.Add(LabelClock);
            Controls.Add(ButtonAwayScoreSubtract3);
            Controls.Add(ButtonHomeScoreSubtract3);
            Controls.Add(ButtonAwayScoreAdd3);
            Controls.Add(ButtonAwayScoreSubtract2);
            Controls.Add(ButtonHomeScoreAdd3);
            Controls.Add(ButtonAwayScoreSubtract1);
            Controls.Add(ButtonHomeScoreSubtract2);
            Controls.Add(ButtonAwayScoreAdd2);
            Controls.Add(ButtonHomeScoreSubtract1);
            Controls.Add(ButtonAwayScoreAdd1);
            Controls.Add(ButtonHomeScoreAdd2);
            Controls.Add(ButtonHomeScoreAdd1);
            Controls.Add(Line);
            Controls.Add(LabelAwayTitle);
            Controls.Add(LabelHomeTitle);
            Controls.Add(ButtonSCSet14S);
            Controls.Add(ButtonSCSetToDefault);
            Controls.Add(ButtonStopClocks);
            Controls.Add(ButtonStartClocks);
            Controls.Add(ControlPanelMenuStrip);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = ControlPanelMenuStrip;
            Name = "ControlPanel";
            ShowIcon = false;
            FormClosing += ControlPanel_FormClosing;
            Load += ControlPanel_Load;
            ControlPanelMenuStrip.ResumeLayout(false);
            ControlPanelMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip ControlPanelMenuStrip;
        private ToolStripMenuItem TeamsMenu;
        private ToolStripMenuItem TeamsMenuHomeChangeName;
        private ToolStripMenuItem TeamsMenuAwayChangeName;
        private ToolStripMenuItem MainClockMenu;
        private ToolStripMenuItem ShotClockMenu;
        private ToolStripMenuItem MainClockMenuSetTime;
        private ToolStripMenuItem MainClockMenuSetDefaultTime;
        private ToolStripMenuItem ShotClockMenuSetTime;
        private ToolStripMenuItem ShotClockMenuSetDefaultTime;
        private Button ButtonStartClocks;
        private Button ButtonStopClocks;
        private ToolStripMenuItem ShotClockMenuToggleShotClock;
        public Button ButtonSCSetToDefault;
        public Button ButtonSCSet14S;
        private ToolStripMenuItem SetBonusFoulThresholdMenuButton;
        private Label Line;
        private Button ButtonHomeScoreAdd1;
        private Button ButtonHomeScoreAdd2;
        private Button ButtonHomeScoreAdd3;
        private Button ButtonHomeScoreSubtract1;
        private Button ButtonHomeScoreSubtract2;
        private Button ButtonHomeScoreSubtract3;
        private Button ButtonAwayScoreAdd1;
        private Button ButtonAwayScoreAdd2;
        private Button ButtonAwayScoreSubtract1;
        private Button ButtonAwayScoreSubtract2;
        private Button ButtonAwayScoreAdd3;
        private Button ButtonAwayScoreSubtract3;
        private ToolStripMenuItem GameMenu;
        private ToolStripMenuItem GameMenuSetPeriod;
        public ToolStripMenuItem TeamsMenuHome;
        public ToolStripMenuItem TeamsMenuAway;
        private ToolStripMenuItem GameMenuSwitchPossession;
        public Label LabelHomeTitle;
        public Label LabelAwayTitle;
        private ToolStripMenuItem TeamsMenuHomeSetFouls;
        private ToolStripMenuItem TeamsMenuAwaySetFouls;
        public Label LabelClock;
        public Label LabelShotClock;
        public Label LabelPeriod;
        public Label LabelAwayPossession;
        public Label LabelHomePossession;
        public Label LabelAwayBonus;
        public Label LabelHomeBonus;
        public Label LabelAwayFouls;
        public Label LabelAwayScore;
        public Label LabelHomeFouls;
        public Label LabelHomeScore;
    }
}