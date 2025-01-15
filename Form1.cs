using System.Data;

namespace Simple_Caculator_Activity_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string input = "";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttons(object sender, EventArgs e)
        {
            Button clickedbutton = (Button)sender;
            if(textBox1.Text == "0 ")
                textBox1.Clear();
            if (clickedbutton != null)
            {
                int caretPosition = textBox1.SelectionStart;
                textBox1.Text = textBox1.Text.Insert(caretPosition, clickedbutton.Text);
                input = input + clickedbutton.Text;
                textBox1.SelectionStart = caretPosition + clickedbutton.Text.Length;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string text = input;
            int length = text.Length;
            if (input.Contains("."))
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                Button clickedbutton = (Button)sender;
                int caretPosition = textBox1.SelectionStart;
                textBox1.Text = textBox1.Text.Insert(caretPosition, clickedbutton.Text);
                input = input + clickedbutton.Text;
                textBox1.SelectionStart = caretPosition + clickedbutton.Text.Length;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int length = text.Length;

            if (textBox1.Text.Length != 0)
            {
                if (textBox1.Text[length - 1] == '+')
                {
                    textBox1.Text = textBox1.Text;
                }
                else
                {
                    input = "\0";
                    Button clickedbutton = (Button)sender;
                    int caretPosition = textBox1.SelectionStart;
                    textBox1.Text = textBox1.Text.Insert(caretPosition, clickedbutton.Text);
                    textBox1.SelectionStart = caretPosition + clickedbutton.Text.Length;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int length = text.Length;

            if (textBox1.Text.Length != 0)
            {
                if (textBox1.Text[length - 1] == '-')
                {
                    textBox1.Text = textBox1.Text;
                }
                else
                {
                    input = "\0";
                    Button clickedbutton = (Button)sender;
                    int caretPosition = textBox1.SelectionStart;
                    textBox1.Text = textBox1.Text.Insert(caretPosition, clickedbutton.Text);
                    textBox1.SelectionStart = caretPosition + clickedbutton.Text.Length;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int length = text.Length;

            if (textBox1.Text.Length != 0)
            {
                if (textBox1.Text[length - 1] == '*')
                {
                    textBox1.Text = textBox1.Text;
                }
                else
                {
                    input = "\0";
                    Button clickedbutton = (Button)sender;
                    int caretPosition = textBox1.SelectionStart;
                    textBox1.Text = textBox1.Text.Insert(caretPosition, clickedbutton.Text);
                    textBox1.SelectionStart = caretPosition + clickedbutton.Text.Length;
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0 ")
                textBox1.Clear();
            textBox1.Text = textBox1.Text.Insert(textBox1.SelectionStart, button18.Text);
            textBox1.SelectionStart = textBox1.Text.Length - 1;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int length = text.Length;

            if (textBox1.Text.Length != 0)
            {
                if (textBox1.Text[length - 1] == '/')
                {
                    textBox1.Text = textBox1.Text;
                }
                else
                {
                    input = "\0";
                    Button clickedbutton = (Button)sender;
                    int caretPosition = textBox1.SelectionStart;
                    textBox1.Text = textBox1.Text.Insert(caretPosition, clickedbutton.Text);
                    textBox1.SelectionStart = caretPosition + clickedbutton.Text.Length;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                string equation = textBox1.Text;
                var result = new DataTable().Compute(equation, null);

                if (double.IsNaN(Convert.ToDouble(result)))
                {
                    throw new Exception("Undefined result");
                }
                if (double.IsInfinity(Convert.ToDouble(result)))
                {
                    throw new Exception("Undefined result");
                }
                else
                {
                    textBox1.Text = result.ToString();
                    textBox1.SelectionStart = textBox1.TextLength;
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            int caretPosition = textBox1.SelectionStart;
            
            if (caretPosition > 0)
            {
                textBox1.Text = textBox1.Text.Remove(caretPosition - 1, 1);
                textBox1.SelectionStart = caretPosition - 1;
                if(textBox1.SelectionStart == 0)
                {
                    textBox1.Clear();
                    textBox1.Text = "0 ";
                    input = "\0";
                }
                else
                    input = textBox1.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0 ";
            input = "\0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double number))
            {
                number = -number;
                textBox1.Text = number.ToString();
                input = textBox1.Text;
                textBox1.SelectionStart = textBox1.TextLength;
            }
        }
    }
}
