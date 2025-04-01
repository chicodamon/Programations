using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Calculator2000
{
    public partial class Form1 : Form
    {
        private double num1 = 0;
        private double num2 = 0;
        private string operador = "";
        private bool running = false;


        public Form1()
        {
            InitializeComponent();
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }
            AddNumber("0");
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }
            AddNumber("1");
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }
            AddNumber("2");
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }
            AddNumber("3");
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }
            AddNumber("4");
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }
            AddNumber("5");
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }
            AddNumber("6");
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }
            AddNumber("7");
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }
            AddNumber("8");
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text == "0")
            {
                DisplayTextBox.Clear();
            }
            AddNumber("9");
        }
        private void AddNumber(string num)
        {
            if (DisplayTextBox.Text == "0" || running)
            {
                DisplayTextBox.Clear();
                running = false;
            }
            DisplayTextBox.Text += num;
        }
        private void btn_dot_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text.Contains("."))
            {
                DisplayTextBox.Text += ".";
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            DisplayTextBox.Text = "0";
            num1 = num2 = 0;
            operador = "";
            running = false;
        }
        private void btn_clearEntry_Click(object sender, EventArgs e)
        {
            if (DisplayTextBox.Text != "0")
            {
                DisplayTextBox.Text = "0";
            }
        }
        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            ChangeOperador("*");
        }
        private void btn_division_Click(object sender, EventArgs e)
        {
            ChangeOperador("/");
        }
        private void btn_sum_Click(object sender, EventArgs e)
        {
            ChangeOperador("+");
        }
        private void btn_subtract_Click(object sender, EventArgs e)
        {
            ChangeOperador("-");
        }
        private void ChangeOperador(string operacao)
        {
            num1 = Double.Parse(DisplayTextBox.Text);
            operador = operacao;
            running = true;
        }
        private void btn_equal_Click(object sender, EventArgs e)
        {
            num2 = Double.Parse(DisplayTextBox.Text);

            switch (operador)
            {
                case "+":
                    DisplayTextBox.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    DisplayTextBox.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    DisplayTextBox.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        DisplayTextBox.Text = (num1 / num2).ToString();
                    }
                    else
                    {
                        DisplayTextBox.Text = "Erro";
                    }
                    break;
                default:
                    break;
            }

            num1 = 0;
            num2 = 0;
            operador = "";
            running = false;
        }
        private void btn_percentage_Click(object sender, EventArgs e)
        {
            num2 = Double.Parse(DisplayTextBox.Text);
            double result = num1 * (num2 / 100);
            DisplayTextBox.Text = result.ToString();

            num1 = 0;
            num2 = 0;
            operador = "";
            running = false;
        }
    }
}
