namespace WinFormsExample
{
    public partial class WinFormsExampleForm : Form
    {
        public WinFormsExampleForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        private void SetDefaults()
        {
            NameTextBox.Text = "";
            AgeTextBox.Text = "";
            CityTextBox.Text = "";
            PhoneTextBox.Text = "";

            UpperCaseRadioButton.Checked = true;
            LowerCaseRadioButton.Checked = false;
            ReverseButton.Checked = false;
        }

        //Event Handlers Below

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Text = NameTextBox.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
    }
}
