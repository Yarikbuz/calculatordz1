namespace Calculator
{
    public partial class Form1 : Form
    {
        bool gg = true;
        string cc = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gg == true)
            {
                textBox1.Text = textBox1.Text + 1;
            }
            else
            {
                textBox2.Text = textBox2.Text + 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (gg == true)
            {
                textBox1.Text = textBox1.Text + 2;
            }
            else
            {
                textBox2.Text = textBox2.Text + 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gg == true)
            {
                textBox1.Text = textBox1.Text + 3;
            }
            else
            {
                textBox2.Text = textBox2.Text + 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (gg == true)
            {
                textBox1.Text = textBox1.Text + 4;
            }
            else
            {
                textBox2.Text = textBox2.Text + 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (gg == true)
            {
                textBox1.Text = textBox1.Text + 5;
            }
            else
            {
                textBox2.Text = textBox2.Text + 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (gg == true)
            {
                textBox1.Text = textBox1.Text + 6;
            }
            else
            {
                textBox2.Text = textBox2.Text + 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (gg == true)
            {
                textBox1.Text = textBox1.Text + 7;
            }
            else
            {
                textBox2.Text = textBox2.Text + 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (gg == true)
            {
                textBox1.Text = textBox1.Text + 8;
            }
            else
            {
                textBox2.Text = textBox2.Text + 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (gg == true)
            {
                textBox1.Text = textBox1.Text + 9;
            }
            else
            {
                textBox2.Text = textBox2.Text + 9;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (gg == true)
            {
                textBox1.Text = textBox1.Text + 0;
            }
            else
            {
                textBox2.Text = textBox2.Text + 0;
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            gg = false;
            cc = "+";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            gg = false;
            cc = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);
            float num3 = 0;
            switch(cc)
            {
                case "+":
                    num3 = num1 + num2;
                    textBox3.Text = num3.ToString();
                    break;
                case "-":
                    num3 = num1 - num2;
                    textBox3.Text = num3.ToString();
                    break;
                case "*":
                    num3 = num1* num2;
                    textBox3.Text = num3.ToString();
                    break;
                case "/":
                    num3 = num1/ num2;
                    textBox3.Text = num3.ToString();
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            gg = true;
            cc = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            gg = false;
            cc = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            gg = false;
            cc = "/";
        }
    }
}
