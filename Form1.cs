
using System.IO;

namespace FinalProject

{
    public partial class Form1 : Form
    {
        private Panel pnlLogin; // Changed type from object to Panel
        private Panel pnlSignUp; // Changed type from object to Panel
        

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "Search";
            textBox1.ForeColor = Color.Gray;

            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Search";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductCard card = new ProductCard();

            card.ProductName = "AMD Ryzen 7 7800X3D";
            card.Price = "₱26,095.00";
            string imagePath = Path.Combine(Application.StartupPath, "Images", "Screenshot 2026-07-08 153341.png");
            card.ProductImage = Image.FromFile(imagePath);





            flowLayoutPanel1.Controls.Add(card);
        }

        private void productCard2_Load(object sender, EventArgs e)
        {




        }
    }
}


