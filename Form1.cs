namespace FinalProject
{
    public partial class Form1 : Form
    {
        private Panel pnlLogin; // Changed type from object to Panel
        private Panel pnlSignUp; // Changed type from object to Panel

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }
    }
}


