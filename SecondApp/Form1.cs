namespace SecondApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String firstName = tbFirstName.Text;
            String lastName = tbLastName.Text;
            lbWelcome.Text = firstName + " " + lastName;   
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            lbWelcome.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "";
        }
    }
}