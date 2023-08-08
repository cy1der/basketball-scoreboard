namespace Basketball_Scoreboard_System.forms
{
    public partial class NumberInput : Form
    {
        public int Number { get; set; }

        public NumberInput() => InitializeComponent();

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

        private void NumberSelector_ValueChanged(object sender, EventArgs e)
        {
            Number = (int)NumberSelector.Value;
            NumberSelector.Text = Number.ToString();
        }
    }
}