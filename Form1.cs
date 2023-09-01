namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(maskedTextBox1.Text);
            int nilai2 = int.Parse(maskedTextBox2.Text);
            int hasil;
            hasil = nilai1 + nilai2;
            maskedTextBox3.Text = hasil.ToString();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(maskedTextBox1.Text);
            int nilai2 = int.Parse(maskedTextBox2.Text);
            int hasil;
            hasil = nilai1 - nilai2;
            maskedTextBox3.Text = hasil.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(maskedTextBox1.Text);
            int nilai2 = int.Parse(maskedTextBox2.Text);
            int hasil;
            hasil = nilai1 * nilai2;
            maskedTextBox3.Text = hasil.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(maskedTextBox1.Text);
            int nilai2 = int.Parse(maskedTextBox2.Text);
            int hasil;
            hasil = nilai1 / nilai2;
            maskedTextBox3.Text = hasil.ToString();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}