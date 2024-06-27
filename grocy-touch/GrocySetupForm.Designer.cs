namespace grocy_touch
{
    partial class GrocySetupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SaveButton = new Button();
            label1 = new Label();
            GrocyUrlTextBox = new TextBox();
            GrocyApiKeyTextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(276, 64);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "Grocy API URL";
            // 
            // GrocyUrlTextBox
            // 
            GrocyUrlTextBox.Location = new Point(101, 6);
            GrocyUrlTextBox.MaxLength = 255;
            GrocyUrlTextBox.Name = "GrocyUrlTextBox";
            GrocyUrlTextBox.Size = new Size(250, 23);
            GrocyUrlTextBox.TabIndex = 2;
            // 
            // GrocyApiKeyTextBox
            // 
            GrocyApiKeyTextBox.Location = new Point(101, 35);
            GrocyApiKeyTextBox.MaxLength = 255;
            GrocyApiKeyTextBox.Name = "GrocyApiKeyTextBox";
            GrocyApiKeyTextBox.Size = new Size(250, 23);
            GrocyApiKeyTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 3;
            label2.Text = "Grocy API Key";
            // 
            // GrocySetupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 94);
            Controls.Add(GrocyApiKeyTextBox);
            Controls.Add(label2);
            Controls.Add(GrocyUrlTextBox);
            Controls.Add(label1);
            Controls.Add(SaveButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GrocySetupForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Grocy Configuration";
            Load += GrocySetupForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveButton;
        private Label label1;
        private TextBox GrocyUrlTextBox;
        private TextBox GrocyApiKeyTextBox;
        private Label label2;
    }
}