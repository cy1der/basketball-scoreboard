namespace Basketball_Scoreboard_System.forms
{
    public partial class ShotClockTimeSet : Form
    {
        public int S { get; set; }

        public ShotClockTimeSet() => InitializeComponent();

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SecondsSelector_ValueChanged(object sender, EventArgs e)
        {
            S = (int)SecondsSelector.Value;
            SecondsSelector.Text = S.ToString();
        }
    }
}