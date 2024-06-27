using Microsoft.VisualBasic;

namespace grocy_touch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FirstRun)
            {
                MessageBox.Show("On first run please configure the Grocy connection", "First run", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var grocySetupFormHandle = new GrocySetupForm();
                grocySetupFormHandle.ShowDialog();

            }

            if (Properties.Settings.Default.GrocyApiEndpoint != null)
            {
                GrocyApiUrlStatusLabel.Text = Properties.Settings.Default.GrocyApiEndpoint;
            }
        }

        private void OpenGrocySettingsButton_Click(object sender, EventArgs e)
        {
            var grocySetupFormHandle = new GrocySetupForm();
            grocySetupFormHandle.ShowDialog();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
