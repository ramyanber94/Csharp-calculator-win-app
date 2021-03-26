using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N01379722_week02
{
    public partial class calcFrm : Form
    {
        string input = "";
        string x = "";
        string y = "";
        char operation;
        double result = 0.0;
        public calcFrm()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            input += "1";
            txtInput.Text += input;
          

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            x = input;
            operation = '+';
            input = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            y = input;
            double num1, num2;
            double.TryParse(x, out num1);
            double.TryParse(y, out num2);


            if (operation == '+')
            {
                result = num1 + num2;
                txtInput.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                txtInput.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                txtInput.Text = result.ToString();
            }
            else if (operation == '/')
            {
                result = num1 / num2;
                txtInput.Text = result.ToString();

            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            KeyPreview = true;
            txtInput.Text = "";
            input += "2";
            txtInput.Text += input;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            KeyPreview = true;
            txtInput.Text = "";
            input += "3";
            txtInput.Text += input;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            KeyPreview = true;
            txtInput.Text = "";
            input += "4";
            txtInput.Text += input;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            KeyPreview = true;
            txtInput.Text = "";
            input += "5";
            txtInput.Text += input;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            KeyPreview = true;
            txtInput.Text = "";
            input += "6";
            txtInput.Text += input;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            KeyPreview = true;
            txtInput.Text = "";
            input += "7";
            txtInput.Text += input;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            KeyPreview = true;
            txtInput.Text = "";
            input += "8";
            txtInput.Text += input;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            KeyPreview = true;
            txtInput.Text = "";
            input += "9";
            txtInput.Text += input;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            x = input;
            operation = '/';
            input = "";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            x = input;
            operation = '*';
            input = "";
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            x = input;
            operation = '-';
            input = "";
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            input += "0";
            txtInput.Text += input;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            input = "";
            x = "";
            y = "";
        }

        private void btnPranthies_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRightPran_Click(object sender, EventArgs e)
        {
            
        }

        private void NumPad1(object sender, KeyPressEventArgs e)
        {
            
        }

        private void NumPad1(object sender, KeyEventArgs e)
        {
            KeyPreview = true;
            if (e.KeyCode == Keys.NumPad1)
            {
                btn1.PerformClick();
            }
        }

        private void NumPad2(object sender, KeyEventArgs e)
        {
            KeyPreview = true;
            if (e.KeyCode == Keys.NumPad2)
            {
                btnTwo.PerformClick();
            }
        }

        private void NumPad3(object sender, KeyEventArgs e)
        {
            KeyPreview = true;
            if (e.KeyCode == Keys.NumPad3)
            {
                btnThree.PerformClick();
            }
        }

        private void NumPad4(object sender, KeyEventArgs e)
        {
            KeyPreview = true;
            if (e.KeyCode == Keys.NumPad4)
            {
                btnFour.PerformClick();
            }
        }

        private void NumPad5(object sender, KeyEventArgs e)
        {
            KeyPreview = true;
            if (e.KeyCode == Keys.NumPad5)
            {
                btnFive.PerformClick();
            }
        }

        private void NumPad6(object sender, KeyEventArgs e)
        {
            KeyPreview = true;
            if (e.KeyCode == Keys.NumPad6)
            {
                btnSix.PerformClick();
            }
        }

        private void NumPad7(object sender, KeyEventArgs e)
        {
            KeyPreview = true;
            if (e.KeyCode == Keys.NumPad7)
            {
                btnSeven.PerformClick();
            }
        }

        private void NumPad8(object sender, KeyEventArgs e)
        {
            KeyPreview = true;
            if (e.KeyCode == Keys.NumPad8)
            {
                btnEight.PerformClick();
            }
        }

        private void NumPad9(object sender, KeyEventArgs e)
        {
            KeyPreview = true;
            if (e.KeyCode == Keys.NumPad9)
            {
                btnNine.PerformClick();
            }
        }

        private void Enum(object sender, KeyEventArgs e)
        {
            KeyPreview = true;
            if (e.KeyCode == Keys.OemMinus)
            {
                btnSubstract.PerformClick();
            }
        }

        private void NumPad3(object sender, KeyPressEventArgs e)
        {
            KeyPreview = true;
            if (e.KeyChar == (char)Keys.NumPad3)
            {
                btnThree.PerformClick();
            }
        }

        private void calcFrm_Load(object sender, EventArgs e)
        {
            
        }

        private void eventLisnerBG_DoWork(object sender, DoWorkEventArgs e)
        {
           
        }

        private void NumPad2Press(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
