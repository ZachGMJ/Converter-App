namespace Coonverter_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = textBox1.Text;
            if(double.TryParse(input, out double num))
            {
                if(num > 0)
                {
                    if (radioButton1.Checked)
                    {
                        converted.Text = num + " inches is " + Convert.ToString(num * 0.0254)p + " meters";
                    }
                    else if (radioButton2.Checked)
                    {
                        converted.Text = num + " meters is " + Convert.ToString(num * 39.3701) + " inches";
                    }
                    converted.Visible = true;
                }
                else
                {
                    MessageBox.Show("Number you entered is negative");
                }
            }
            else
            {
                MessageBox.Show("What you entered is not numeric");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            converted.Visible = false;
        }
    }
}
