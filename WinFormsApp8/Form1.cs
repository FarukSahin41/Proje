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
            
            if (textBox1.Text == "Faruk �ahin" && textBox2.Text == "132130031")
            {
                Form2 a� = new Form2();
                a�.Show();
            }
            else
            {
                MessageBox.Show("Hatal� Giri�");
            }
            
            





            


        }
    }
}