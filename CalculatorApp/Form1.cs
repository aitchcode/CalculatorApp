namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string aux;
        string aux2;
        char lastOp;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = null;
            textBox2.Text = "0";
            aux = string.Empty;
            aux2 = string.Empty;
            lastOp = '$';
        }

        void compute()
        {
            switch (lastOp)
            {
                case '+':
                    textBox2.Text = (Convert.ToDouble(textBox2.Text) + Convert.ToDouble(aux)).ToString();
                    break;
                case '-':
                    textBox2.Text = (Convert.ToDouble(textBox2.Text) - Convert.ToDouble(aux)).ToString();
                    break;
                case '*':
                    textBox2.Text = (Convert.ToDouble(textBox2.Text) * Convert.ToDouble(aux)).ToString();
                    break;
                case '/':
                    textBox2.Text = (Convert.ToDouble(textBox2.Text) / Convert.ToDouble(aux)).ToString();
                    break;
                default:
                    textBox2.Text = (Convert.ToDouble(textBox1.Text)).ToString();
                    break;
            }
        }

        void myFun(char chr)
        {
            double d = Convert.ToDouble(textBox2.Text);
            if (double.IsNaN(d) || double.IsInfinity(d))
            {
                //textBox1.Text = null;
                textBox2.Text = "0";
                //aux = string.Empty;
                aux2 = string.Empty;
                lastOp = '$';
            }
            if (lastOp=='=')
            {
                textBox1.Text+=aux2;
            }
            if (textBox1.Text != "")
            {
                char c = textBox1.Text[textBox1.Text.Length - 1];
                switch (c)
                {
                    case '+':
                        break;
                    case '-':
                        break;
                    case '*':
                        break;
                    case '/':
                        break;
                    case '.':
                        break;
                    default:
                        compute();
                        textBox1.Text += chr;
                        lastOp=chr;
                        aux = string.Empty;
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            aux += "1";
            aux2 = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            aux += "2";
            aux2 = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            aux += "3";
            aux2 = string.Empty;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            aux += "0";
            aux2 = string.Empty;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            aux += "4";
            aux2 = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            aux += "5";
            aux2 = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            aux += "6";
            aux2 = string.Empty;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            aux += "7";
            aux2 = string.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            aux += "8";
            aux2 = string.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            aux += "9";
            aux2 = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!aux.Contains('.'))
            {
                aux += '.';
                textBox1.Text += '.';
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            myFun('$');
            textBox1.Text = null;
            aux = string.Empty;
            aux2 = textBox2.Text;
            lastOp = '=';
        }

        private void button16_Click(object sender, EventArgs e)
        {
            myFun('+');
        }

        private void button15_Click(object sender, EventArgs e)
        {
            myFun('-');
        }

        private void button14_Click(object sender, EventArgs e)
        {
            myFun('*');
        }

        private void button13_Click(object sender, EventArgs e)
        {
            myFun('/');
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = "0";
            aux = string.Empty;
            aux2 = string.Empty;
            lastOp = '$';
        }
    }
}