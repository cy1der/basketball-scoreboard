namespace Basketball_Scoreboard_System.classes
{
    public class Team
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Fouls { get; set; }
        public bool Bonus { get; set; }
        public bool IsHome { get; set; }
        public bool IsAway { get; set; }
        public bool Possession { get; set; }
        public List<Player> Players { get; set; }

        public Team(bool IsHomeTeam, bool IsAwayTeam, bool HasPossession)
        {
            Players = new List<Player>();
            Score = 0;
            Fouls = 0;
            Bonus = false;

            IsAway = IsAwayTeam;
            IsHome = IsHomeTeam;
            Possession = HasPossession;

            if (IsHome && !IsAway)
            {
                Name = Settings.Default.HomeTeamName ?? "HOME";
                Program.AudienceWindow.LabelHomeTeamName.Text = Name;
            }
            else if (!IsHome && IsAway)
            {
                Name = Settings.Default.AwayTeamName ?? "AWAY";
                Program.AudienceWindow.LabelAwayTeamName.Text = Name;
            }
            else
            {
                Name = "ERROR";
                MessageBox.Show("Team not initialized properly", "Error", MessageBoxButtons.AbortRetryIgnore);
            }
        }

        public void ChangeTeamName(string NewName)
        {
            Name = NewName;
            if (IsHome && !IsAway)
            {
                Settings.Default.HomeTeamName = NewName;
                Settings.Default.Save();
                Program.AudienceWindow.LabelHomeTeamName.Text = Settings.Default.HomeTeamName;
                Program.ControlPanel.TeamsMenuHome.Text = Settings.Default.HomeTeamName;
                Program.ControlPanel.LabelHomeTitle.Text = Settings.Default.HomeTeamName;
            }
            else if (!IsHome && IsAway)
            {
                Settings.Default.AwayTeamName = NewName;
                Settings.Default.Save();
                Program.AudienceWindow.LabelAwayTeamName.Text = Settings.Default.AwayTeamName;
                Program.ControlPanel.TeamsMenuAway.Text = Settings.Default.AwayTeamName;
                Program.ControlPanel.LabelAwayTitle.Text = Settings.Default.AwayTeamName;
            }
        }

        public void ChangeScore(int Amount)
        {
            if (Score + Amount < 0 || Score + Amount > 999) MessageBox.Show("Score cannot be less than 0 or greater than 999", "Warning", MessageBoxButtons.OK);
            else
            {
                Score += Amount;
                if (IsHome && !IsAway)
                {
                    Program.AudienceWindow.LabelHomeScore.Text = Score.ToString();
                    Program.ControlPanel.LabelHomeScore.Text = Score.ToString();
                }
                else if (!IsHome && IsAway)
                {
                    Program.AudienceWindow.LabelAwayScore.Text = Score.ToString();
                    Program.ControlPanel.LabelAwayScore.Text = Score.ToString();
                }
            }
        }

        public static string FormatFouls(int Fouls)
        {
            if (Fouls < 10) return "0" + Fouls.ToString();
            else return Fouls.ToString();
        }

        public static string FormatScore(int Score)
        {
            if (Score < 10) return "0" + Score.ToString();
            else return Score.ToString();
        }
    }
}