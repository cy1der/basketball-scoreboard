namespace Basketball_Scoreboard_System.forms
{
    public partial class TeamNameInput : Form
    {
        public TeamNameInput(string Name)
        {
            InitializeComponent();
            TeamName = Name;
        }

        public string TeamName { get; set; }

        private void TeamNameTextBox_TextChanged(object sender, EventArgs e) => TeamName = TeamNameTextBox.Text;

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if (TeamName.Length < 4) MessageBox.Show("Team name cannot be less than 4 characters", "Invalid Entry", MessageBoxButtons.OK);
            else if (TeamName.Length > 7) MessageBox.Show("Team name cannot be more than 7 characters", "Invalid Entry", MessageBoxButtons.OK);
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}