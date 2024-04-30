namespace Coonverter_App
{
    public partial class Form1 : Form
    {
        public int currentList = 0;
        String file = "C:\\Users\\space\\OneDrive\\Documents\\GUI\\measurements.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            var input = textBox1.Text;
            if (double.TryParse(input, out double num))
            {
                if (num > 0)
                {
                    if (radioButton1.Checked)
                    {
                        converted.Text = num + " inches is " + System.Convert.ToString(num * 0.0254) + " meters";
                    }
                    else if (radioButton2.Checked)
                    {
                        converted.Text = num + " meters is " + System.Convert.ToString(num * 39.3701) + " inches";
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

        private void ClearRes_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            converted.Visible = false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (converted.Visible)
            {
                List.AppendText(converted.Text + "\n");
                currentList++;

            }
            else
            {
                MessageBox.Show("Try entering a measurement first");
            }
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {

            if (System.IO.File.Exists(file))
            {
                StreamWriter sw = new StreamWriter(file, false);
                sw.Write(List.Text);
                sw.Close();
                tracker.Text = "Saved " + currentList + " entries to file measurements.txt";
                tracker.Visible = true;
            }
            else
            {
                MessageBox.Show("File doesn't exist");
            }

        }

        private void clearList_Click(object sender, EventArgs e)
        {
            List.Clear();
            currentList = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
