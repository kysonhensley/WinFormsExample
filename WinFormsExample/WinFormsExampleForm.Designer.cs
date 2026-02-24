namespace WinFormsExample
{
    partial class WinFormsExampleForm
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
            SubmitButton = new Button();
            ExitButton = new Button();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            PhoneLabel = new Label();
            AgeTextBox = new TextBox();
            AgeLabel = new Label();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(362, 380);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.RightToLeft = RightToLeft.Yes;
            SubmitButton.Size = new Size(138, 58);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(650, 380);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(138, 58);
            ExitButton.TabIndex = 6;
            ExitButton.TabStop = false;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 75);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(67, 72);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(180, 27);
            NameTextBox.TabIndex = 0;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(67, 138);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(180, 27);
            PhoneTextBox.TabIndex = 2;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(12, 178);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 4;
            CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(67, 171);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(180, 27);
            CityTextBox.TabIndex = 3;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(12, 141);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(50, 20);
            PhoneLabel.TabIndex = 6;
            PhoneLabel.Text = "Phone";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(67, 105);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(180, 27);
            AgeTextBox.TabIndex = 1;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(12, 108);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(36, 20);
            AgeLabel.TabIndex = 8;
            AgeLabel.Text = "Age";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(506, 380);
            ClearButton.Name = "ClearButton";
            ClearButton.RightToLeft = RightToLeft.Yes;
            ClearButton.Size = new Size(138, 58);
            ClearButton.TabIndex = 5;
            ClearButton.TabStop = false;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            // 
            // WinFormsExampleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearButton);
            Controls.Add(AgeTextBox);
            Controls.Add(AgeLabel);
            Controls.Add(CityTextBox);
            Controls.Add(PhoneLabel);
            Controls.Add(PhoneTextBox);
            Controls.Add(CityLabel);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(ExitButton);
            Controls.Add(SubmitButton);
            Name = "WinFormsExampleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitButton;
        private Button ExitButton;
        private Label NameLabel;
        private TextBox NameTextBox;
        private TextBox PhoneTextBox;
        private Label CityLabel;
        private TextBox CityTextBox;
        private Label PhoneLabel;
        private TextBox AgeTextBox;
        private Label AgeLabel;
        private Button ClearButton;
    }
}
