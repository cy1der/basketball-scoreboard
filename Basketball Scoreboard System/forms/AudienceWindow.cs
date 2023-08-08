using System.Media;

namespace Basketball_Scoreboard_System.forms
{
    public partial class AudienceWindow : Form
    {
        private readonly SoundPlayer BuzzerMainClock = new(Properties.Resources.BuzzerMainClock);
        private readonly SoundPlayer BuzzerShotClock = new(Properties.Resources.BuzzerShotClock);

        public AudienceWindow() => InitializeComponent();

        private void LabelHomeTeamName_Paint(object sender, PaintEventArgs e) => LabelHomeTeamName.Font = Program.GetFontSize(e.Graphics, LabelHomeTeamName.Text, new Size(LabelHomeTeamName.Width - 12, LabelHomeTeamName.Height), LabelHomeTeamName.Font);

        private void LabelAwayTeamName_Paint(object sender, PaintEventArgs e) => LabelAwayTeamName.Font = Program.GetFontSize(e.Graphics, LabelAwayTeamName.Text, new Size(LabelAwayTeamName.MaximumSize.Width - 12, LabelAwayTeamName.MaximumSize.Height), LabelAwayTeamName.Font);

        private void AudienceWindow_Load(object sender, EventArgs e) => Program.ControlPanel.Show();

        private void AudienceWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Confirmation = MessageBox.Show("Are you sure you want to exit?\nGame progress will not be saved.", "Confirm", MessageBoxButtons.YesNo);
            if (Confirmation == DialogResult.No) e.Cancel = true;
        }

        private void MainClockTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Program.MainClock.Time > 0)
            {
                Program.MainClock.Time -= (int)Program.AudienceWindow.MainClockTimer.Interval;
                Program.MainClock.DisplayTime();
            }
            else
            {
                Program.AudienceWindow.MainClockTimer.Stop();
                BuzzerMainClock.Play();
            }
        }

        private void ShotClockTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (Program.ShotClock.Time > 0)
            {
                Program.ShotClock.Time -= (int)Program.AudienceWindow.ShotClockTimer.Interval;
                Program.ShotClock.DisplayTime();
            }
            else
            {
                Program.AudienceWindow.ShotClockTimer.Stop();
                BuzzerShotClock.Play();
            }
        }
    }
}