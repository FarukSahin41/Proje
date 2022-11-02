namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "Faruk Þahin" && textBox2.Text == "132130031")
            {
                Form2 aç = new Form2();
                aç.Show();
            }
            else
            {
                MessageBox.Show("Hatalý Giriþ");
            }
            
            





            


        }
    }
}