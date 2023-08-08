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
            ControlPanelMenuStrip.Location = new Point(0, 0);
            ControlPanelMenuStrip.Name = "ControlPanelMenuStrip";
            ControlPanelMenuStrip.RenderMode = ToolStripRenderMode.System;
            ControlPanelMenuStrip.Size = new Size(490, 24);
            ControlPanelMenuStrip.TabIndex = 1;
            ControlPanelMenuStrip.Text = "Control Panel Menu";
            // 
            // GameMenu
            // 
            GameMenu.DropDownItems.AddRange(new ToolStripItem[] { GameMenuSetPeriod, GameMenuSwitchPossession });
            GameMenu.Name = "GameMenu";
            GameMenu.Size = new Size(50, 20);
            GameMenu.Text = "Game";
            // 
            // GameMenuSetPeriod
            // 
            GameMenuSetPeriod.Name = "GameMenuSetPeriod";
            GameMenuSetPeriod.Size = new Size(169, 22);
            GameMenuSetPeriod.Text = "Set Period";
            GameMenuSetPeriod.Click += GameMenuSetPeriod_Click;
            // 
            // GameMenuSwitchPossession
            // 
            GameMenuSwitchPossession.Name = "GameMenuSwitchPossession";
            GameMenuSwitchPossession.Size = new Size(169, 22);
            GameMenuSwitchPossession.Text = "Switch Possession";
            GameMenuSwitchPossession.Click += GameMenuSwitchPossession_Click;
            // 
            // TeamsMenu
            // 
            TeamsMenu.DropDownItems.AddRange(new ToolStripItem[] { TeamsMenuHome, TeamsMenuAway, SetBonusFoulThresholdMenuButton });
            TeamsMenu.Name = "TeamsMenu";
            TeamsMenu.Size = new Size(52, 20);
            TeamsMenu.Text = "Teams";
            // 
            // TeamsMenuHome
            // 
            TeamsMenuHome.DropDownItems.AddRange(new ToolStripItem[] { TeamsMenuHomeChangeName, TeamsMenuHomeSetFouls });
            TeamsMenuHome.Name = "TeamsMenuHome";
            TeamsMenuHome.Size = new Size(207, 22);
            TeamsMenuHome.Text = "Home";
            // 
            // TeamsMenuHomeChangeName
            // 
            TeamsMenuHomeChangeName.Name = "TeamsMenuHomeChangeName";
            TeamsMenuHomeChangeName.Size = new Size(150, 22);
            TeamsMenuHomeChangeName.Text = "Change Name";
            TeamsMenuHomeChangeName.Click += TeamsMenuHomeChangeName_Click;
            // 
            // TeamsMenuHomeSetFouls
            // 
            TeamsMenuHomeSetFouls.Name = "TeamsMenuHomeSetFouls";
            TeamsMenuHomeSetFouls.Size = new Size(150, 22);
            TeamsMenuHomeSetFouls.Text = "Set Fouls";
            TeamsMenuHomeSetFouls.Click += TeamsMenuHomeSetFouls_Click;
            // 
            // TeamsMenuAway
            // 
            TeamsMenuAway.DropDownItems.AddRange(new ToolStripItem[] { TeamsMenuAwayChangeName, TeamsMenuAwaySetFouls });
            TeamsMenuAway.Name = "TeamsMenuAway";
            TeamsMenuAway.Size = new Size(207, 22);
            TeamsMenuAway.Text = "Away";
            // 
            // TeamsMenuAwayChangeName
            // 
            TeamsMenuAwayChangeName.Name = "TeamsMenuAwayChangeName";
            TeamsMenuAwayChangeName.Size = new Size(150, 22);
            TeamsMenuAwayChangeName.Text = "Change Name";
            TeamsMenuAwayChangeName.Click += TeamsMenuAwayChangeName_Click;
            // 
            // TeamsMenuAwaySetFouls
            // 
            TeamsMenuAwaySetFouls.Name = "TeamsMenuAwaySetFouls";
            TeamsMenuAwaySetFouls.Size = new Size(150, 22);
            TeamsMenuAwaySetFouls.Text = "Set Fouls";
            TeamsMenuAwaySetFouls.Click += TeamsMenuAwaySetFouls_Click;
            // 
            // SetBonusFoulThresholdMenuButton
            // 
            SetBonusFoulThresholdMenuButton.Name = "SetBonusFoulThresholdMenuButton";
            SetBonusFoulThresholdMenuButton.Size = new Size(207, 22);
            SetBonusFoulThresholdMenuButton.Text = "Set Bonus Foul Threshold";
            SetBonusFoulThresholdMenuButton.Click += SetBonusFoulThresholdMenuButton_Click;
            // 
            // MainClockMenu
            // 
            MainClockMenu.DropDownItems.AddRange(new ToolStripItem[] { MainClockMenuSetTime, MainClockMenuSetDefaultTime });
            MainClockMenu.Name = "MainClockMenu";
            MainClockMenu.Size = new Size(79, 20);
            MainClockMenu.Text = "Main Clock";
            // 
            // MainClockMenuSetTime
            // 
            MainClockMenuSetTime.Name = "MainClockMenuSetTime";
            MainClockMenuSetTime.Size = new Size(160, 22);
            MainClockMenuSetTime.Text = "Set Time";
            MainClockMenuSetTime.Click += MainClockMenuSetTime_Click;
            // 
            // MainClockMenuSetDefaultTime
            // 
            MainClockMenuSetDefaultTime.Name = "MainClockMenuSetDefaultTime";
            MainClockMenuSetDefaultTime.Size = new Size(160, 22);
            MainClockMenuSetDefaultTime.Text = "Set Default Time";
            MainClockMenuSetDefaultTime.Click += MainClockMenuSetDefaultTime_Click;
            // 
            // ShotClockMenu
            // 
            ShotClockMenu.DropDownItems.AddRange(new ToolStripItem[] { ShotClockMenuSetTime, ShotClockMenuSetDefaultTime, ShotClockMenuToggleShotClock });
            ShotClockMenu.Name = "ShotClockMenu";
            ShotClockMenu.Size = new Size(76, 20);
            ShotClockMenu.Text = "Shot Clock";
            // 
            // ShotClockMenuSetTime
            // 
            ShotClockMenuSetTime.Name = "ShotClockMenuSetTime";
            ShotClockMenuSetTime.Size = new Size(169, 22);
            ShotClockMenuSetTime.Text = "Set Time";
            ShotClockMenuSetTime.Click += ShotClockMenuSetTime_Click;
            // 
            // ShotClockMenuSetDefaultTime
            // 
            ShotClockMenuSetDefaultTime.Name = "ShotClockMenuSetDefaultTime";
            ShotClockMenuSetDefaultTime.Size = new Size(169, 22);
            ShotClockMenuSetDefaultTime.Text = "Set Default Time";
            ShotClockMenuSetDefaultTime.Click += ShotClockMenuSetDefaultTime_Click;
            // 
            // ShotClockMenuToggleShotClock
            // 
            ShotClockMenuToggleShotClock.Name = "ShotClockMenuToggleShotClock";
            ShotClockMenuToggleShotClock.Size = new Size(169, 22);
            ShotClockMenuToggleShotClock.Text = "Toggle Shot Clock";
            ShotClockMenuToggleShotClock.Click += ShotClockMenuToggleShotClock_Click;
            // 
            // ButtonStartClocks
            // 
            ButtonStartClocks.BackColor = Color.FromArgb(192, 255, 192);
            ButtonStartClocks.FlatStyle = FlatStyle.Flat;
            ButtonStartClocks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonStartClocks.Location = new Point(12, 35);
            ButtonStartClocks.Name = "ButtonStartClocks";
            ButtonStartClocks.Size = new Size(128, 64);
            ButtonStartClocks.TabIndex = 2;
            ButtonStartClocks.Text = "Start Clocks";
            ButtonStartClocks.UseVisualStyleBackColor = false;
            ButtonStartClocks.Click += ButtonStartClocks_Click;
            // 
            // ButtonStopClocks
            // 
            ButtonStopClocks.BackColor = Color.FromArgb(255, 192, 192);
            ButtonStopClocks.FlatStyle = FlatStyle.Flat;
            ButtonStopClocks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonStopClocks.Location = new Point(146, 35);
            ButtonStopClocks.Name = "ButtonStopClocks";
            ButtonStopClocks.Size = new Size(128, 64);
            ButtonStopClocks.TabIndex = 3;
            ButtonStopClocks.Text = "Stop Clocks";
            ButtonStopClocks.UseVisualStyleBackColor = false;
            ButtonStopClocks.Click += ButtonStopClocks_Click;
            // 
            // ButtonSCSetToDefault
            // 
            ButtonSCSetToDefault.FlatStyle = FlatStyle.Flat;
            ButtonSCSetToDefault.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSCSetToDefault.Location = new Point(280, 35);
            ButtonSCSetToDefault.Name = "ButtonSCSetToDefault";
            ButtonSCSetToDefault.Size = new Size(96, 64);
            ButtonSCSetToDefault.TabIndex = 4;
            ButtonSCSetToDefault.Text = "Shot Clock\r\nSet XXs";
            ButtonSCSetToDefault.UseVisualStyleBackColor = true;
            ButtonSCSetToDefault.Click += ButtonSCSetToDefault_Click;
            // 
            // ButtonSCSet14S
            // 
            ButtonSCSet14S.FlatStyle = FlatStyle.Flat;
            ButtonSCSet14S.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonSCSet14S.Location = new Point(382, 35);
            ButtonSCSet14S.Name = "ButtonSCSet14S";
            ButtonSCSet14S.Size = new Size(96, 64);
            ButtonSCSet14S.TabIndex = 5;
            ButtonSCSet14S.Text = "Shot Clock\r\nSet 14s";
            ButtonSCSet14S.UseVisualStyleBackColor = true;
            ButtonSCSet14S.Click += ButtonSCSet14S_Click;
            // 
            // LabelHomeTitle
            // 
            LabelHomeTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHomeTitle.Location = new Point(12, 106);
            LabelHomeTitle.Name = "LabelHomeTitle";
            LabelHomeTitle.Size = new Size(227, 65);
            LabelHomeTitle.TabIndex = 6;
            LabelHomeTitle.Text = "Home";
            LabelHomeTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelAwayTitle
            // 
            LabelAwayTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAwayTitle.Location = new Point(252, 106);
            LabelAwayTitle.Name = "LabelAwayTitle";
            LabelAwayTitle.Size = new Size(226, 65);
            LabelAwayTitle.TabIndex = 8;
            LabelAwayTitle.Text = "Away";
            LabelAwayTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Line
            // 
            Line.BorderStyle = BorderStyle.Fixed3D;
            Line.Location = new Point(245, 106);
            Line.Name = "Line";
            Line.Size = new Size(1, 291);
            Line.TabIndex = 9;
            // 
            // ButtonHomeScoreAdd1
            // 
            ButtonHomeScoreAdd1.FlatStyle = FlatStyle.Flat;
            ButtonHomeScoreAdd1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonHomeScoreAdd1.Location = new Point(128, 174);
            ButtonHomeScoreAdd1.Name = "ButtonHomeScoreAdd1";
            ButtonHomeScoreAdd1.Size = new Size(64, 67);
            ButtonHomeScoreAdd1.TabIndex = 10;
            ButtonHomeScoreAdd1.Text = "+1";
            ButtonHomeScoreAdd1.UseVisualStyleBackColor = true;
            ButtonHomeScoreAdd1.Click += ButtonHomeScoreAdd1_Click;
            // 
            // ButtonHomeScoreAdd2
            // 
            ButtonHomeScoreAdd2.FlatStyle = FlatStyle.Flat;
            ButtonHomeScoreAdd2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonHomeScoreAdd2.Location = new Point(128, 244);
            ButtonHomeScoreAdd2.Name = "ButtonHomeScoreAdd2";
            ButtonHomeScoreAdd2.Size = new Size(64, 67);
            ButtonHomeScoreAdd2.TabIndex = 10;
            ButtonHomeScoreAdd2.Text = "+2";
            ButtonHomeScoreAdd2.UseVisualStyleBackColor = true;
            ButtonHomeScoreAdd2.Click += ButtonHomeScoreAdd2_Click;
            // 
            // ButtonHomeScoreAdd3
            // 
            ButtonHomeScoreAdd3.FlatStyle = FlatStyle.Flat;
            ButtonHomeScoreAdd3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonHomeScoreAdd3.Location = new Point(128, 314);
            ButtonHomeScoreAdd3.Name = "ButtonHomeScoreAdd3";
            ButtonHomeScoreAdd3.Size = new Size(64, 67);
            ButtonHomeScoreAdd3.TabIndex = 10;
            ButtonHomeScoreAdd3.Text = "+3";
            ButtonHomeScoreAdd3.UseVisualStyleBackColor = true;
            ButtonHomeScoreAdd3.Click += ButtonHomeScoreAdd3_Click;
            // 
            // ButtonHomeScoreSubtract1
            // 
            ButtonHomeScoreSubtract1.FlatStyle = FlatStyle.Flat;
            ButtonHomeScoreSubtract1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonHomeScoreSubtract1.Location = new Point(58, 174);
            ButtonHomeScoreSubtract1.Name = "ButtonHomeScoreSubtract1";
            ButtonHomeScoreSubtract1.Size = new Size(64, 67);
            ButtonHomeScoreSubtract1.TabIndex = 10;
            ButtonHomeScoreSubtract1.Text = "-1";
            ButtonHomeScoreSubtract1.UseVisualStyleBackColor = true;
            ButtonHomeScoreSubtract1.Click += ButtonHomeScoreSubtract1_Click;
            // 
            // ButtonHomeScoreSubtract2
            // 
            ButtonHomeScoreSubtract2.FlatStyle = FlatStyle.Flat;
            ButtonHomeScoreSubtract2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonHomeScoreSubtract2.Location = new Point(58, 244);
            ButtonHomeScoreSubtract2.Name = "ButtonHomeScoreSubtract2";
            ButtonHomeScoreSubtract2.Size = new Size(64, 67);
            ButtonHomeScoreSubtract2.TabIndex = 10;
            ButtonHomeScoreSubtract2.Text = "-2";
            ButtonHomeScoreSubtract2.UseVisualStyleBackColor = true;
            ButtonHomeScoreSubtract2.Click += ButtonHomeScoreSubtract2_Click;
            // 
            // ButtonHomeScoreSubtract3
            // 
            ButtonHomeScoreSubtract3.FlatStyle = FlatStyle.Flat;
            ButtonHomeScoreSubtract3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonHomeScoreSubtract3.Location = new Point(58, 314);
            ButtonHomeScoreSubtract3.Name = "ButtonHomeScoreSubtract3";
            ButtonHomeScoreSubtract3.Size = new Size(64, 67);
            ButtonHomeScoreSubtract3.TabIndex = 10;
            ButtonHomeScoreSubtract3.Text = "-3";
            ButtonHomeScoreSubtract3.UseVisualStyleBackColor = true;
            ButtonHomeScoreSubtract3.Click += ButtonHomeScoreSubtract3_Click;
            // 
            // ButtonAwayScoreAdd1
            // 
            ButtonAwayScoreAdd1.FlatStyle = FlatStyle.Flat;
            ButtonAwayScoreAdd1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAwayScoreAdd1.Location = new Point(368, 174);
            ButtonAwayScoreAdd1.Name = "ButtonAwayScoreAdd1";
            ButtonAwayScoreAdd1.Size = new Size(64, 67);
            ButtonAwayScoreAdd1.TabIndex = 10;
            ButtonAwayScoreAdd1.Text = "+1";
            ButtonAwayScoreAdd1.UseVisualStyleBackColor = true;
            ButtonAwayScoreAdd1.Click += ButtonAwayScoreAdd1_Click;
            // 
            // ButtonAwayScoreAdd2
            // 
            ButtonAwayScoreAdd2.FlatStyle = FlatStyle.Flat;
            ButtonAwayScoreAdd2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAwayScoreAdd2.Location = new Point(368, 244);
            ButtonAwayScoreAdd2.Name = "ButtonAwayScoreAdd2";
            ButtonAwayScoreAdd2.Size = new Size(64, 67);
            ButtonAwayScoreAdd2.TabIndex = 10;
            ButtonAwayScoreAdd2.Text = "+2";
            ButtonAwayScoreAdd2.UseVisualStyleBackColor = true;
            ButtonAwayScoreAdd2.Click += ButtonAwayScoreAdd2_Click;
            // 
            // ButtonAwayScoreSubtract1
            // 
            ButtonAwayScoreSubtract1.FlatStyle = FlatStyle.Flat;
            ButtonAwayScoreSubtract1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAwayScoreSubtract1.Location = new Point(298, 174);
            ButtonAwayScoreSubtract1.Name = "ButtonAwayScoreSubtract1";
            ButtonAwayScoreSubtract1.Size = new Size(64, 67);
            ButtonAwayScoreSubtract1.TabIndex = 10;
            ButtonAwayScoreSubtract1.Text = "-1";
            ButtonAwayScoreSubtract1.UseVisualStyleBackColor = true;
            ButtonAwayScoreSubtract1.Click += ButtonAwayScoreSubtract1_Click;
            // 
            // ButtonAwayScoreSubtract2
            // 
            ButtonAwayScoreSubtract2.FlatStyle = FlatStyle.Flat;
            ButtonAwayScoreSubtract2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAwayScoreSubtract2.Location = new Point(298, 244);
            ButtonAwayScoreSubtract2.Name = "ButtonAwayScoreSubtract2";
            ButtonAwayScoreSubtract2.Size = new Size(64, 67);
            ButtonAwayScoreSubtract2.TabIndex = 10;
            ButtonAwayScoreSubtract2.Text = "-2";
            ButtonAwayScoreSubtract2.UseVisualStyleBackColor = true;
            ButtonAwayScoreSubtract2.Click += ButtonAwayScoreSubtract2_Click;
            // 
            // ButtonAwayScoreAdd3
            // 
            ButtonAwayScoreAdd3.FlatStyle = FlatStyle.Flat;
            ButtonAwayScoreAdd3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAwayScoreAdd3.Location = new Point(368, 314);
            ButtonAwayScoreAdd3.Name = "ButtonAwayScoreAdd3";
            ButtonAwayScoreAdd3.Size = new Size(64, 67);
            ButtonAwayScoreAdd3.TabIndex = 10;
            ButtonAwayScoreAdd3.Text = "+3";
            ButtonAwayScoreAdd3.UseVisualStyleBackColor = true;
            ButtonAwayScoreAdd3.Click += ButtonAwayScoreAdd3_Click;
            // 
            // ButtonAwayScoreSubtract3
            // 
            ButtonAwayScoreSubtract3.FlatStyle = FlatStyle.Flat;
            ButtonAwayScoreSubtract3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAwayScoreSubtract3.Location = new Point(298, 314);
            ButtonAwayScoreSubtract3.Name = "ButtonAwayScoreSubtract3";
            ButtonAwayScoreSubtract3.Size = new Size(64, 67);
            ButtonAwayScoreSubtract3.TabIndex = 10;
            ButtonAwayScoreSubtract3.Text = "-3";
            ButtonAwayScoreSubtract3.UseVisualStyleBackColor = true;
            ButtonAwayScoreSubtract3.Click += ButtonAwayScoreSubtract3_Click;
            // 
            // LabelClock
            // 
            LabelClock.Location = new Point(212, 400);
            LabelClock.Name = "LabelClock";
            LabelClock.Size = new Size(66, 23);
            LabelClock.TabIndex = 11;
            LabelClock.Text = "--:--";
            LabelClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelShotClock
            // 
            LabelShotClock.Location = new Point(229, 425);
            LabelShotClock.Name = "LabelShotClock";
            LabelShotClock.Size = new Size(33, 23);
            LabelShotClock.TabIndex = 12;
            LabelShotClock.Text = "--";
            LabelShotClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelPeriod
            // 
            LabelPeriod.Location = new Point(229, 448);
            LabelPeriod.Name = "LabelPeriod";
            LabelPeriod.Size = new Size(33, 23);
            LabelPeriod.TabIndex = 13;
            LabelPeriod.Text = "-";
            LabelPeriod.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelAwayPossession
            // 
            LabelAwayPossession.Location = new Point(268, 448);
            LabelAwayPossession.Name = "LabelAwayPossession";
            LabelAwayPossession.Size = new Size(33, 23);
            LabelAwayPossession.TabIndex = 14;
            LabelAwayPossession.Text = ">";
            LabelAwayPossession.TextAlign = ContentAlignment.MiddleCenter;
            LabelAwayPossession.Visible = false;
            // 
            // LabelHomePossession
            // 
            LabelHomePossession.Location = new Point(190, 448);
            LabelHomePossession.Name = "LabelHomePossession";
            LabelHomePossession.Size = new Size(33, 23);
            LabelHomePossession.TabIndex = 14;
            LabelHomePossession.Text = "<";
            LabelHomePossession.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelAwayBonus
            // 
            LabelAwayBonus.Location = new Point(268, 425);
            LabelAwayBonus.Name = "LabelAwayBonus";
            LabelAwayBonus.Size = new Size(33, 23);
            LabelAwayBonus.TabIndex = 14;
            LabelAwayBonus.Text = "B";
            LabelAwayBonus.TextAlign = ContentAlignment.MiddleCenter;
            LabelAwayBonus.Visible = false;
            // 
            // LabelHomeBonus
            // 
            LabelHomeBonus.Location = new Point(190, 425);
            LabelHomeBonus.Name = "LabelHomeBonus";
            LabelHomeBonus.Size = new Size(33, 23);
            LabelHomeBonus.TabIndex = 14;
            LabelHomeBonus.Text = "B";
            LabelHomeBonus.TextAlign = ContentAlignment.MiddleCenter;
            LabelHomeBonus.Visible = false;
            // 
            // LabelAwayFouls
            // 
            LabelAwayFouls.Location = new Point(307, 448);
            LabelAwayFouls.Name = "LabelAwayFouls";
            LabelAwayFouls.Size = new Size(33, 23);
            LabelAwayFouls.TabIndex = 14;
            LabelAwayFouls.Text = "-";
            LabelAwayFouls.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelAwayScore
            // 
            LabelAwayScore.Location = new Point(307, 425);
            LabelAwayScore.Name = "LabelAwayScore";
            LabelAwayScore.Size = new Size(33, 23);
            LabelAwayScore.TabIndex = 14;
            LabelAwayScore.Text = "0";
            LabelAwayScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelHomeFouls
            // 
            LabelHomeFouls.Location = new Point(151, 448);
            LabelHomeFouls.Name = "LabelHomeFouls";
            LabelHomeFouls.Size = new Size(33, 23);
            LabelHomeFouls.TabIndex = 14;
            LabelHomeFouls.Text = "-";
            LabelHomeFouls.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelHomeScore
            // 
            LabelHomeScore.Location = new Point(151, 425);
            LabelHomeScore.Name = "LabelHomeScore";
            LabelHomeScore.Size = new Size(33, 23);
            LabelHomeScore.TabIndex = 14;
            LabelHomeScore.Text = "0";
            LabelHomeScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(490, 483);
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
            MainMenuStrip = ControlPanelMenuStrip;
            MaximumSize = new Size(506, 522);
            MinimumSize = new Size(506, 522);
            Name = "ControlPanel";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control Panel";
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