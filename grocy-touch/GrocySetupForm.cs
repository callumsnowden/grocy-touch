using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grocy_touch
{
    public partial class GrocySetupForm : Form
    {
        public GrocySetupForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.GrocyApiEndpoint = GrocyUrlTextBox.Text;
            Properties.Settings.Default.GrocyApiKey = GrocyApiKeyTextBox.Text;
            if (Properties.Settings.Default.FirstRun)
            {
                Properties.Settings.Default.FirstRun = false;
            }
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void GrocySetupForm_Load(object sender, EventArgs e)
        {
            GrocyUrlTextBox.Text = Properties.Settings.Default.GrocyApiEndpoint;
            GrocyApiKeyTextBox.Text = Properties.Settings.Default.GrocyApiKey;
        }
    }
}
