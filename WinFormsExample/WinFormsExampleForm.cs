namespace WinFormsExample
{
    public partial class WinFormsExampleForm : Form
    {
        public WinFormsExampleForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Text = "Hello";
        }
    }
}
