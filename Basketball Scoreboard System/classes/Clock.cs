namespace Basketball_Scoreboard_System.classes
{
    public class Clock
    {
        public int DefaultTime { get; set; }
        public int Time { get; set; }
        public bool IsShotClock { get; set; }
        public bool IsMainClock { get; set; }

        public Clock(int DefaultTime, bool IsSC, bool IsMC)
        {
            this.DefaultTime = DefaultTime;
            Time = DefaultTime;
            IsMainClock = IsMC;
            IsShotClock = IsSC;
            if (!((IsMainClock && !IsShotClock) || (!IsMainClock && IsShotClock))) MessageBox.Show("Clock not initialized properly", "Error", MessageBoxButtons.AbortRetryIgnore);
        }

        public void DisplayTime()
        {
            if (IsMainClock)
            {
                Program.AudienceWindow.LabelClock.Text = FormatTimeMC();
                Program.ControlPanel.LabelClock.Text = FormatTimeMC();
            }
            else if (IsShotClock)
            {
                Program.AudienceWindow.LabelShotClock.Text = FormatTimeSC();
                Program.ControlPanel.LabelShotClock.Text = FormatTimeSC();
            }
        }

        public string FormatTimeMC()
        {
            TimeSpan ParsedTime = TimeSpan.FromMilliseconds(Time);

            if (ParsedTime.Minutes == 0)
            {
                string MS = (ParsedTime.Milliseconds / 10).ToString();
                string Seconds = ParsedTime.Seconds.ToString();
                if (ParsedTime.Seconds < 10) Seconds = "0" + ParsedTime.Seconds;
                if (ParsedTime.Milliseconds / 100 == 0) MS = "00";
                return Seconds + "." + MS;
            }
            else
            {
                string Minutes = ParsedTime.Minutes.ToString();
                string Seconds = ParsedTime.Seconds.ToString();
                if (ParsedTime.Minutes < 10) Minutes = "0" + ParsedTime.Minutes;
                if (ParsedTime.Seconds < 10) Seconds = "0" + ParsedTime.Seconds;
                return Minutes + ":" + Seconds;
            }
        }

        public string FormatTimeSC()
        {
            TimeSpan ParsedTime = TimeSpan.FromMilliseconds(Time);
            return ParsedTime.Seconds.ToString();
        }

        public void SCUpdateButtonLabel()
        {
            TimeSpan SCS = TimeSpan.FromMilliseconds(DefaultTime);
            Program.ControlPanel.ButtonSCSetToDefault.Text = "Shot Clock\nSet " + SCS.Seconds.ToString() + "s";
        }
    }
}