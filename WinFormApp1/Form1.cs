namespace WinFormApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char number = e.KeyChar;

            if((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }

            if((textBox1.Text.Contains(',') == true) && (number == 44))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numb = 0.0;

            numb = Convert.ToDouble(textBox1.Text);

            if (checkBox1.Checked == true)
            {
                numb = numb / 2.54;
            }
            else
            {
            }

            label3.Text = numb.ToString();
        }
    }
}