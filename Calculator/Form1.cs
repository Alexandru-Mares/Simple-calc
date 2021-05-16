using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string message = "Fill the coresponding box/boxes";
        double firstNumber = 0, secondNumber = 0;
        bool control = false;
        Regex regex = new Regex("^[-]{0,1}[0-9]{0,15}[.]{0,1}[0-9]{0,15}$");
        public Form1()
        {
            InitializeComponent();
        }
        bool textChangedByKey;
        string lastText;
        bool firstNrChangedByKey, SecondNrChangeByKey;
        string lastFirstNr,lastSecondNr;
        void set2Parameter(string text, string text2)
        {
            //test if the texboxes are populated
            if (text.Trim() != "" && text2.Trim() != "")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
                secondNumber = Convert.ToDouble(text2);
            }
            else control = false;
        }
        private void txtbFirstNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.KeyChar.ToString()) + "1"))
            {
                e.Handled = true;
                return;
            }
            firstNrChangedByKey = true;
        }

        private void txtbSecondNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsControl(e.KeyChar)) return;
            if (!regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.KeyChar.ToString()) + "1"))
            {
                e.Handled = true;
                return;
            }
            SecondNrChangeByKey = true;


        }
      
        void setParameter(string text)
        {
            if (text.Trim() !="")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
            }
            else control = false;

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            control = false;
            txtbFirstNr.Clear();
            txtbSecondNr.Clear();
            txtbRes.Clear();
            firstNumber = 0;
            secondNumber = 0;
        }
      
        private void btnMin_Click(object sender, EventArgs e)
        {
            set2Parameter(txtbFirstNr.Text, txtbSecondNr.Text);
            if(!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtbRes.Text = Math.Min(firstNumber, secondNumber).ToString();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            set2Parameter(txtbFirstNr.Text, txtbSecondNr.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtbRes.Text = Math.Max(firstNumber, secondNumber).ToString();
            }

        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            setParameter(txtbFirstNr.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                txtbRes.Text = Math.Abs(firstNumber).ToString();
            }
        }
        private void testbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!regex.IsMatch((sender as TextBox).Text.Insert((sender as TextBox).SelectionStart, e.KeyChar.ToString()) + "1"))
            {
                e.Handled = true;
                return;
            }
            textChangedByKey = true;

        }
  
        

        private void txtbFirstNr_TextChanged(object sender, EventArgs e)
        {
            if (!firstNrChangedByKey)
            {
                if (!regex.IsMatch((sender as TextBox).Text))
                {
                    txtbFirstNr.Text = lastFirstNr;
                    return;
                }
            }
            else firstNrChangedByKey = false;
            lastFirstNr = txtbFirstNr.Text;
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            setParameter(txtbFirstNr.Text);
            if(!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                double temp = (firstNumber * Math.PI) / 180;
                txtbRes.Text = Math.Sin(temp).ToString();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            setParameter(txtbFirstNr.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                double temp = (firstNumber * Math.PI) / 180;
                txtbRes.Text = Math.Cos(temp).ToString();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            setParameter(txtbFirstNr.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                double temp = (firstNumber * Math.PI) / 180;
                txtbRes.Text = Math.Tan(temp).ToString();
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            set2Parameter(txtbFirstNr.Text,txtbSecondNr.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                double temp = Math.Pow(firstNumber, secondNumber);
                txtbRes.Text = temp.ToString();
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            setParameter(txtbFirstNr.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                
                txtbRes.Text = Math.Sqrt(firstNumber).ToString();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtbSecondNr.Text == "")
            {
                setParameter(txtbFirstNr.Text);
                if (!control)
                {
                    MessageBox.Show(message);
                }
                else
                {

                    txtbRes.Text = Math.Log(firstNumber).ToString();
                }
            }
            else
            {
                set2Parameter(txtbFirstNr.Text, txtbSecondNr.Text);
                if (!control)
                {
                    MessageBox.Show(message);
                }
                else
                {

                    txtbRes.Text = Math.Log(firstNumber,secondNumber).ToString();
                }
            }
        }

        private void btnLog10_Click(object sender, EventArgs e)
        {
            setParameter(txtbFirstNr.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {

                txtbRes.Text = Math.Log10(firstNumber).ToString();
            }

        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            setParameter(txtbFirstNr.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {

                txtbRes.Text = Math.Exp(firstNumber).ToString();
            }
        }

        private void btnCopyFirst_Click(object sender, EventArgs e)
        {
            if( txtbRes.Text.Trim()!="")
            txtbFirstNr.Text = txtbRes.Text;
            txtbRes.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtbRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRes_Click(object sender, EventArgs e)
        {

        }

        private void lblSecNr_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstNr_Click(object sender, EventArgs e)
        {

        }

        private void txtbRes_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            set2Parameter(txtbFirstNr.Text, txtbSecondNr.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                double diff = firstNumber - secondNumber;
                txtbRes.Text = diff.ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            set2Parameter(txtbFirstNr.Text, txtbSecondNr.Text);
            if (!control)
            {
                MessageBox.Show(message);
            }
            else
            {
                double sum = firstNumber + secondNumber;
                txtbRes.Text = sum.ToString();
            }
        }

        private void txtbSecondNr_TextChanged(object sender, EventArgs e)
        {
            if (!SecondNrChangeByKey)
            {
                if (!regex.IsMatch((sender as TextBox).Text))
                {
                    txtbSecondNr.Text = lastSecondNr;
                    return;
                }
            }
            else SecondNrChangeByKey = false;
            lastSecondNr = txtbSecondNr.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

      

        
    }
}
