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
            ButtonGroupBox = new GroupBox();
            UserInfoGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox3 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox4 = new CheckBox();
            LowerCaseRadioButton = new RadioButton();
            UpperCaseRadioButton = new RadioButton();
            ReverseButton = new RadioButton();
            ButtonGroupBox.SuspendLayout();
            UserInfoGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(24, 37);
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
            ExitButton.Location = new Point(312, 37);
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
            NameLabel.Location = new Point(21, 58);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(76, 55);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(180, 27);
            NameTextBox.TabIndex = 0;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(76, 121);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(180, 27);
            PhoneTextBox.TabIndex = 2;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(21, 161);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 4;
            CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(76, 154);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(180, 27);
            CityTextBox.TabIndex = 3;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(21, 124);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(50, 20);
            PhoneLabel.TabIndex = 6;
            PhoneLabel.Text = "Phone";
            // 
            // AgeTextBox
            // 
            AgeTextBox.Location = new Point(76, 88);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(180, 27);
            AgeTextBox.TabIndex = 1;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(21, 91);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(36, 20);
            AgeLabel.TabIndex = 8;
            AgeLabel.Text = "Age";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(168, 37);
            ClearButton.Name = "ClearButton";
            ClearButton.RightToLeft = RightToLeft.Yes;
            ClearButton.Size = new Size(138, 58);
            ClearButton.TabIndex = 5;
            ClearButton.TabStop = false;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ButtonGroupBox
            // 
            ButtonGroupBox.Controls.Add(ClearButton);
            ButtonGroupBox.Controls.Add(SubmitButton);
            ButtonGroupBox.Controls.Add(ExitButton);
            ButtonGroupBox.Location = new Point(316, 318);
            ButtonGroupBox.Name = "ButtonGroupBox";
            ButtonGroupBox.Size = new Size(472, 120);
            ButtonGroupBox.TabIndex = 5;
            ButtonGroupBox.TabStop = false;
            // 
            // UserInfoGroupBox
            // 
            UserInfoGroupBox.Controls.Add(NameTextBox);
            UserInfoGroupBox.Controls.Add(NameLabel);
            UserInfoGroupBox.Controls.Add(AgeTextBox);
            UserInfoGroupBox.Controls.Add(CityLabel);
            UserInfoGroupBox.Controls.Add(AgeLabel);
            UserInfoGroupBox.Controls.Add(PhoneTextBox);
            UserInfoGroupBox.Controls.Add(CityTextBox);
            UserInfoGroupBox.Controls.Add(PhoneLabel);
            UserInfoGroupBox.Location = new Point(12, 12);
            UserInfoGroupBox.Name = "UserInfoGroupBox";
            UserInfoGroupBox.Size = new Size(274, 206);
            UserInfoGroupBox.TabIndex = 0;
            UserInfoGroupBox.TabStop = false;
            UserInfoGroupBox.Text = "User Info";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(316, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(472, 300);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(192, 167);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(117, 24);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "radioButton4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(192, 197);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(192, 137);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(191, 85);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(191, 55);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(167, 261);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(167, 288);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(101, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // LowerCaseRadioButton
            // 
            LowerCaseRadioButton.AutoSize = true;
            LowerCaseRadioButton.Location = new Point(33, 291);
            LowerCaseRadioButton.Name = "LowerCaseRadioButton";
            LowerCaseRadioButton.Size = new Size(70, 24);
            LowerCaseRadioButton.TabIndex = 4;
            LowerCaseRadioButton.TabStop = true;
            LowerCaseRadioButton.Text = "Lower";
            LowerCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // UpperCaseRadioButton
            // 
            UpperCaseRadioButton.AutoSize = true;
            UpperCaseRadioButton.Location = new Point(33, 261);
            UpperCaseRadioButton.Name = "UpperCaseRadioButton";
            UpperCaseRadioButton.Size = new Size(71, 24);
            UpperCaseRadioButton.TabIndex = 1;
            UpperCaseRadioButton.TabStop = true;
            UpperCaseRadioButton.Text = "Upper";
            UpperCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // ReverseButton
            // 
            ReverseButton.AutoSize = true;
            ReverseButton.Location = new Point(33, 318);
            ReverseButton.Name = "ReverseButton";
            ReverseButton.Size = new Size(81, 24);
            ReverseButton.TabIndex = 7;
            ReverseButton.TabStop = true;
            ReverseButton.Text = "Reverse";
            ReverseButton.UseVisualStyleBackColor = true;
            // 
            // WinFormsExampleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReverseButton);
            Controls.Add(UpperCaseRadioButton);
            Controls.Add(checkBox4);
            Controls.Add(LowerCaseRadioButton);
            Controls.Add(groupBox1);
            Controls.Add(checkBox2);
            Controls.Add(UserInfoGroupBox);
            Controls.Add(ButtonGroupBox);
            Name = "WinFormsExampleForm";
            ButtonGroupBox.ResumeLayout(false);
            UserInfoGroupBox.ResumeLayout(false);
            UserInfoGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox ButtonGroupBox;
        private GroupBox UserInfoGroupBox;
        private GroupBox groupBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox4;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private RadioButton LowerCaseRadioButton;
        private RadioButton UpperCaseRadioButton;
        private RadioButton ReverseButton;
    }
}
