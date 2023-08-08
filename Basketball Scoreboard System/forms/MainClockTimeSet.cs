namespace Basketball_Scoreboard_System.forms
{
    public partial class MainClockTimeSet : Form
    {
        public int M { get; set; }
        public int S { get; set; }
        public int MS { get; set; }

        public MainClockTimeSet() => InitializeComponent();

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

        private void MinutesSelector_ValueChanged(object sender, EventArgs e)
        {
            M = (int)MinutesSelector.Value;
            MinutesSelector.Text = M.ToString();
        }

        private void SecondsSelector_ValueChanged(object sender, EventArgs e)
        {
            S = (int)SecondsSelector.Value;
            SecondsSelector.Text = S.ToString();
        }

        private void MSSelector_ValueChanged(object sender, EventArgs e)
        {
            MS = (int)MSSelector.Value;
            MSSelector.Text = MS.ToString();
        }
    }
}