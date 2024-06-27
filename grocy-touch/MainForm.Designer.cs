namespace grocy_touch
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OpenGrocySettingsButton = new Button();
            QuitButton = new Button();
            statusStrip1 = new StatusStrip();
            GrocyVersionStatusLabel = new ToolStripStatusLabel();
            GrocyApiUrlStatusLabel = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // OpenGrocySettingsButton
            // 
            OpenGrocySettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            OpenGrocySettingsButton.Location = new Point(1133, 12);
            OpenGrocySettingsButton.Name = "OpenGrocySettingsButton";
            OpenGrocySettingsButton.Size = new Size(140, 23);
            OpenGrocySettingsButton.TabIndex = 1;
            OpenGrocySettingsButton.Text = "Open Grocy Settings";
            OpenGrocySettingsButton.UseVisualStyleBackColor = true;
            OpenGrocySettingsButton.Click += OpenGrocySettingsButton_Click;
            // 
            // QuitButton
            // 
            QuitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            QuitButton.Location = new Point(1279, 12);
            QuitButton.Name = "QuitButton";
            QuitButton.Size = new Size(75, 23);
            QuitButton.TabIndex = 3;
            QuitButton.Text = "Quit";
            QuitButton.UseMnemonic = false;
            QuitButton.UseVisualStyleBackColor = true;
            QuitButton.Click += QuitButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { GrocyApiUrlStatusLabel, GrocyVersionStatusLabel });
            statusStrip1.Location = new Point(0, 746);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1366, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // GrocyVersionStatusLabel
            // 
            GrocyVersionStatusLabel.Name = "GrocyVersionStatusLabel";
            GrocyVersionStatusLabel.Size = new Size(76, 17);
            GrocyVersionStatusLabel.Text = "GrocyVersion";
            // 
            // GrocyApiUrlStatusLabel
            // 
            GrocyApiUrlStatusLabel.Name = "GrocyApiUrlStatusLabel";
            GrocyApiUrlStatusLabel.Size = new Size(71, 17);
            GrocyApiUrlStatusLabel.Text = "GrocyApiUrl";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 768);
            Controls.Add(statusStrip1);
            Controls.Add(QuitButton);
            Controls.Add(OpenGrocySettingsButton);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "grocy-touch";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenGrocySettingsButton;
        private Button QuitButton;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel GrocyApiUrlStatusLabel;
        private ToolStripStatusLabel GrocyVersionStatusLabel;
    }
}
