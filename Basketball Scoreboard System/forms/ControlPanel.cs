namespace Basketball_Scoreboard_System.forms
{
    public partial class ControlPanel : Form
    {
        public ControlPanel() => InitializeComponent();

        private void ControlPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("This window can be closed by closing the audience window");
            e.Cancel = true;
        }

        private void TeamsMenuHomeChangeName_Click(object sender, EventArgs e)
        {
            TeamNameInput TeamNameInput = new(Program.HomeTeam.Name);
            if (TeamNameInput.ShowDialog() == DialogResult.OK) Program.HomeTeam.ChangeTeamName(TeamNameInput.TeamName);
        }

        private void TeamsMenuAwayChangeName_Click(object sender, EventArgs e)
        {
            TeamNameInput TeamNameInput = new(Program.AwayTeam.Name);
            if (TeamNameInput.ShowDialog() == DialogResult.OK) Program.AwayTeam.ChangeTeamName(TeamNameInput.TeamName);
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            Program.MainClock.DisplayTime();
            Program.ShotClock.DisplayTime();
            Program.AudienceWindow.LabelPeriod.Text = Program.Period.ToString();
            LabelPeriod.Text = Program.Period.ToString();
            Program.AudienceWindow.LabelHomeTeamFouls.Text = Program.HomeTeam.Fouls.ToString();
            LabelHomeFouls.Text = Program.HomeTeam.Fouls.ToString();
            Program.AudienceWindow.LabelAwayTeamFouls.Text = Program.AwayTeam.Fouls.ToString();
            LabelAwayFouls.Text = Program.AwayTeam.Fouls.ToString();

            TeamsMenuHome.Text = Settings.Default.HomeTeamName;
            TeamsMenuAway.Text = Settings.Default.AwayTeamName;
            LabelHomeTitle.Text = Settings.Default.HomeTeamName;
            LabelAwayTitle.Text = Settings.Default.AwayTeamName;

            if (Settings.Default.ShotClockEnabled) Program.ShotClock.SCUpdateButtonLabel();
            else
            {
                Program.AudienceWindow.LabelShotClock.Hide();
                Program.AudienceWindow.LabelShotClockTitle.Hide();
                ButtonSCSetToDefault.Hide();
                ButtonSCSet14S.Hide();
            }
        }

        private void MainClockMenuSetTime_Click(object sender, EventArgs e)
        {
            if (Program.AudienceWindow.MainClockTimer.Enabled) MessageBox.Show("Clock must be stopped", "", MessageBoxButtons.OK);
            else
            {
                TimeSpan CurrentTime = TimeSpan.FromMilliseconds(Program.MainClock.Time);

                MainClockTimeSet MainClockTimeSet = new();

                MainClockTimeSet.MinutesSelector.Value = CurrentTime.Minutes;
                MainClockTimeSet.SecondsSelector.Value = CurrentTime.Seconds;
                MainClockTimeSet.MSSelector.Value = CurrentTime.Milliseconds;

                if (MainClockTimeSet.ShowDialog() == DialogResult.OK)
                {
                    TimeSpan NewTime = TimeSpan.FromMinutes(MainClockTimeSet.M) + TimeSpan.FromSeconds(MainClockTimeSet.S) + TimeSpan.FromMilliseconds(MainClockTimeSet.MS);

                    Program.MainClock.Time = (int)NewTime.TotalMilliseconds;
                    Program.MainClock.DisplayTime();
                }
            }
        }

        private void MainClockMenuSetDefaultTime_Click(object sender, EventArgs e)
        {
            if (Program.AudienceWindow.MainClockTimer.Enabled) MessageBox.Show("Clock must be stopped", "", MessageBoxButtons.OK);
            else
            {
                TimeSpan CurrentTime = TimeSpan.FromMilliseconds(Program.MainClock.Time);

                MainClockTimeSet MainClockTimeSet = new();

                MainClockTimeSet.MinutesSelector.Value = CurrentTime.Minutes;
                MainClockTimeSet.SecondsSelector.Value = CurrentTime.Seconds;
                MainClockTimeSet.MSSelector.Value = CurrentTime.Milliseconds;

                if (MainClockTimeSet.ShowDialog() == DialogResult.OK)
                {
                    TimeSpan NewTime = TimeSpan.FromMinutes(MainClockTimeSet.M) + TimeSpan.FromSeconds(MainClockTimeSet.S) + TimeSpan.FromMilliseconds(MainClockTimeSet.MS);

                    Settings.Default.MainClockDefaultTime = (int)NewTime.TotalMilliseconds;
                    Settings.Default.Save();

                    Program.MainClock.Time = (int)NewTime.TotalMilliseconds;
                    Program.MainClock.DisplayTime();
                }
            }
        }

        private void ShotClockMenuSetTime_Click(object sender, EventArgs e)
        {
            if (!Settings.Default.ShotClockEnabled) MessageBox.Show("Shot Clock is disabled", "", MessageBoxButtons.OK);
            else
            {
                if (Program.AudienceWindow.ShotClockTimer.Enabled) MessageBox.Show("Shot Clock must be stopped", "", MessageBoxButtons.OK);
                else
                {
                    TimeSpan CurrentTime = TimeSpan.FromMilliseconds(Program.ShotClock.Time);

                    ShotClockTimeSet ShotClockTimeSet = new();

                    ShotClockTimeSet.SecondsSelector.Value = CurrentTime.Seconds;

                    if (ShotClockTimeSet.ShowDialog() == DialogResult.OK)
                    {
                        TimeSpan NewTime = TimeSpan.FromSeconds(ShotClockTimeSet.S);

                        Program.ShotClock.Time = (int)NewTime.TotalMilliseconds;
                        Program.ShotClock.DisplayTime();
                    }
                }
            }
        }

        private void ShotClockMenuSetDefaultTime_Click(object sender, EventArgs e)
        {
            if (!Settings.Default.ShotClockEnabled) MessageBox.Show("Shot Clock is disabled", "", MessageBoxButtons.OK);
            else
            {
                if (Program.AudienceWindow.ShotClockTimer.Enabled) MessageBox.Show("Shot Clock must be stopped", "", MessageBoxButtons.OK);
                else
                {
                    TimeSpan CurrentTime = TimeSpan.FromMilliseconds(Program.ShotClock.Time);

                    ShotClockTimeSet ShotClockTimeSet = new();

                    ShotClockTimeSet.SecondsSelector.Value = CurrentTime.Seconds;

                    if (ShotClockTimeSet.ShowDialog() == DialogResult.OK)
                    {
                        TimeSpan NewTime = TimeSpan.FromSeconds(ShotClockTimeSet.S);

                        Settings.Default.ShotClockDefaultTime = (int)NewTime.TotalMilliseconds;
                        Settings.Default.Save();

                        Program.ShotClock.Time = (int)NewTime.TotalMilliseconds;
                        Program.ShotClock.DisplayTime();
                    }
                }
            }
        }

        private void ButtonStartClocks_Click(object sender, EventArgs e)
        {
            Program.AudienceWindow.MainClockTimer.Start();
            if (Settings.Default.ShotClockEnabled) Program.AudienceWindow.ShotClockTimer.Start();
        }

        private void ButtonStopClocks_Click(object sender, EventArgs e)
        {
            Program.AudienceWindow.MainClockTimer.Stop();
            if (Settings.Default.ShotClockEnabled) Program.AudienceWindow.ShotClockTimer.Stop();
        }

        private void ShotClockMenuToggleShotClock_Click(object sender, EventArgs e)
        {
            Settings.Default.ShotClockEnabled = !Settings.Default.ShotClockEnabled;
            Settings.Default.Save();
            if (Settings.Default.ShotClockEnabled)
            {
                Program.AudienceWindow.LabelShotClock.Show();
                Program.AudienceWindow.LabelShotClockTitle.Show();
                ButtonSCSetToDefault.Show();
                ButtonSCSet14S.Show();
                LabelShotClock.Show();
                Program.ShotClock.SCUpdateButtonLabel();
            }
            else
            {
                Program.AudienceWindow.LabelShotClock.Hide();
                Program.AudienceWindow.LabelShotClockTitle.Hide();
                ButtonSCSetToDefault.Hide();
                ButtonSCSet14S.Hide();
                LabelShotClock.Hide();
                Program.AudienceWindow.ShotClockTimer.Stop();
            }
        }

        private void ButtonSCSetToDefault_Click(object sender, EventArgs e)
        {
            Program.ShotClock.Time = Settings.Default.ShotClockDefaultTime;
            Program.ShotClock.DisplayTime();
            if (Program.AudienceWindow.ShotClockTimer.Enabled)
            {
                Program.AudienceWindow.ShotClockTimer.Stop();
                Program.AudienceWindow.ShotClockTimer.Start();
            }
        }

        private void ButtonSCSet14S_Click(object sender, EventArgs e)
        {
            Program.ShotClock.Time = (int)TimeSpan.FromSeconds(14).TotalMilliseconds;
            Program.ShotClock.DisplayTime();
            if (Program.AudienceWindow.ShotClockTimer.Enabled)
            {
                Program.AudienceWindow.ShotClockTimer.Stop();
                Program.AudienceWindow.ShotClockTimer.Start();
            }
        }

        private void SetBonusFoulThresholdMenuButton_Click(object sender, EventArgs e)
        {
            NumberInput NumberInput = new()
            {
                Number = Settings.Default.BonusFoulThreshold
            };

            NumberInput.NumberSelector.Value = Settings.Default.BonusFoulThreshold;
            NumberInput.Text = "Enter New Threshold";

            if (NumberInput.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.BonusFoulThreshold = NumberInput.Number;
                Settings.Default.Save();
            }

            if (Program.HomeTeam.Fouls >= Settings.Default.BonusFoulThreshold)
            {
                Program.AwayTeam.Bonus = true;
                Program.AudienceWindow.LabelAwayTeamBonus.Visible = true;
                LabelAwayBonus.Visible = true;
            }
            else
            {
                Program.AwayTeam.Bonus = false;
                Program.AudienceWindow.LabelAwayTeamBonus.Visible = false;
                LabelAwayBonus.Visible = false;
            }

            if (Program.AwayTeam.Fouls >= Settings.Default.BonusFoulThreshold)
            {
                Program.HomeTeam.Bonus = true;
                Program.AudienceWindow.LabelHomeTeamBonus.Visible = true;
                LabelHomeBonus.Visible = true;
            }
            else
            {
                Program.HomeTeam.Bonus = false;
                Program.AudienceWindow.LabelHomeTeamBonus.Visible = false;
                LabelHomeBonus.Visible = false;
            }
        }

        private void ButtonHomeScoreAdd1_Click(object sender, EventArgs e) => Program.HomeTeam.ChangeScore(1);

        private void ButtonHomeScoreAdd2_Click(object sender, EventArgs e) => Program.HomeTeam.ChangeScore(2);

        private void ButtonHomeScoreAdd3_Click(object sender, EventArgs e) => Program.HomeTeam.ChangeScore(3);

        private void ButtonHomeScoreSubtract1_Click(object sender, EventArgs e) => Program.HomeTeam.ChangeScore(-1);

        private void ButtonHomeScoreSubtract2_Click(object sender, EventArgs e) => Program.HomeTeam.ChangeScore(-2);

        private void ButtonHomeScoreSubtract3_Click(object sender, EventArgs e) => Program.HomeTeam.ChangeScore(-3);

        private void ButtonAwayScoreAdd1_Click(object sender, EventArgs e) => Program.AwayTeam.ChangeScore(1);

        private void ButtonAwayScoreAdd2_Click(object sender, EventArgs e) => Program.AwayTeam.ChangeScore(2);

        private void ButtonAwayScoreAdd3_Click(object sender, EventArgs e) => Program.AwayTeam.ChangeScore(3);

        private void ButtonAwayScoreSubtract1_Click(object sender, EventArgs e) => Program.AwayTeam.ChangeScore(-1);

        private void ButtonAwayScoreSubtract2_Click(object sender, EventArgs e) => Program.AwayTeam.ChangeScore(-2);

        private void ButtonAwayScoreSubtract3_Click(object sender, EventArgs e) => Program.AwayTeam.ChangeScore(-3);

        private void GameMenuSetPeriod_Click(object sender, EventArgs e)
        {
            NumberInput NumberInput = new()
            {
                Number = Program.Period
            };

            NumberInput.NumberSelector.Value = Program.Period;
            NumberInput.NumberSelector.Maximum = 9;
            NumberInput.Text = "Enter Period";

            if (NumberInput.ShowDialog() == DialogResult.OK) Program.Period = NumberInput.Number;
            Program.AudienceWindow.LabelPeriod.Text = Program.Period.ToString();
            LabelPeriod.Text = Program.Period.ToString();
        }

        private void GameMenuSwitchPossession_Click(object sender, EventArgs e)
        {
            Program.HomeTeam.Possession = !Program.HomeTeam.Possession;
            Program.AwayTeam.Possession = !Program.AwayTeam.Possession;

            Program.AudienceWindow.LabelHomeTeamPossession.Visible = Program.HomeTeam.Possession;
            Program.AudienceWindow.LabelAwayTeamPossession.Visible = Program.AwayTeam.Possession;

            LabelHomePossession.Visible = Program.HomeTeam.Possession;
            LabelAwayPossession.Visible = Program.AwayTeam.Possession;
        }

        private void TeamsMenuHomeSetFouls_Click(object sender, EventArgs e)
        {
            NumberInput NumberInput = new()
            {
                Number = Program.HomeTeam.Fouls
            };

            NumberInput.NumberSelector.Maximum = 9;
            NumberInput.NumberSelector.Minimum = 0;
            NumberInput.NumberSelector.Value = Program.HomeTeam.Fouls;
            NumberInput.Text = "Enter Fouls";

            if (NumberInput.ShowDialog() == DialogResult.OK) Program.HomeTeam.Fouls = NumberInput.Number;
            Program.AudienceWindow.LabelHomeTeamFouls.Text = Program.HomeTeam.Fouls.ToString();
            LabelHomeFouls.Text = Program.HomeTeam.Fouls.ToString();

            if (Program.HomeTeam.Fouls >= Settings.Default.BonusFoulThreshold)
            {
                Program.AwayTeam.Bonus = true;
                Program.AudienceWindow.LabelAwayTeamBonus.Visible = true;
                LabelAwayBonus.Visible = true;
            }
            else
            {
                Program.AwayTeam.Bonus = false;
                Program.AudienceWindow.LabelAwayTeamBonus.Visible = false;
                LabelAwayBonus.Visible = false;
            }
        }

        private void TeamsMenuAwaySetFouls_Click(object sender, EventArgs e)
        {
            NumberInput NumberInput = new()
            {
                Number = Program.AwayTeam.Fouls
            };

            NumberInput.NumberSelector.Maximum = 9;
            NumberInput.NumberSelector.Minimum = 0;
            NumberInput.NumberSelector.Value = Program.AwayTeam.Fouls;
            NumberInput.Text = "Enter Fouls";

            if (NumberInput.ShowDialog() == DialogResult.OK) Program.AwayTeam.Fouls = NumberInput.Number;
            Program.AudienceWindow.LabelAwayTeamFouls.Text = Program.AwayTeam.Fouls.ToString();
            LabelAwayFouls.Text = Program.AwayTeam.Fouls.ToString();

            if (Program.AwayTeam.Fouls >= Settings.Default.BonusFoulThreshold)
            {
                Program.HomeTeam.Bonus = true;
                Program.AudienceWindow.LabelHomeTeamBonus.Visible = true;
                LabelHomeBonus.Visible = true;
            }
            else
            {
                Program.HomeTeam.Bonus = false;
                Program.AudienceWindow.LabelHomeTeamBonus.Visible = false;
                LabelHomeBonus.Visible = false;
            }
        }
    }
}