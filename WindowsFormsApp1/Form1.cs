using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int firstNumber = 0, lastNumber=0;
        int divisibleTerm = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisibleTerms.Items.Add("2");
            cmbDivisibleTerms.Items.Add("3");
            cmbDivisibleTerms.Items.Add("4");
            cmbDivisibleTerms.Items.Add("5");
            cmbDivisibleTerms.Items.Add("6");
            cmbDivisibleTerms.Items.Add("7");
            cmbDivisibleTerms.Items.Add("8");
            cmbDivisibleTerms.Items.Add("10");
        }
        string divisibleNumber;
        private void cmbDivisibleTerms_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(cmbDivisibleTerms.SelectedItem);
        }
        int controlnumber = 1;

        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBlack.Checked)
            {
                rbBlue.Checked = false;
                rbRed.Checked = false;
                rbGreen.Checked = false;
                txtdivisibleNumbers.ForeColor = Color.Black;
            }
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRed.Checked)
            {
                rbBlue.Checked = false;
                rbBlack.Checked = false;
                rbGreen.Checked = false;
                txtdivisibleNumbers.ForeColor = Color.Red;
            }
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGreen.Checked)
            {
                rbBlue.Checked = false;
                rbRed.Checked = false;
                rbBlack.Checked = false;
                txtdivisibleNumbers.ForeColor = Color.Green;
            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBlue.Checked)
            {
                rbBlack.Checked = false;
                rbRed.Checked = false;
                rbGreen.Checked = false;
                txtdivisibleNumbers.ForeColor = Color.Blue;
            }
        }

        private void chBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chBold.Checked)
            {
                chItalic.Checked = false;
                txtdivisibleNumbers.Font = new Font(txtdivisibleNumbers.Font.FontFamily, txtdivisibleNumbers.Font.Size, FontStyle.Bold);
            }
            else
            {
                txtdivisibleNumbers.Font = new Font(txtdivisibleNumbers.Font.FontFamily, txtdivisibleNumbers.Font.Size, FontStyle.Regular);
            }
        }

        private void chItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chItalic.Checked)
            {
                chBold.Checked = false;
                txtdivisibleNumbers.Font = new Font(txtdivisibleNumbers.Font.FontFamily, txtdivisibleNumbers.Font.Size, txtdivisibleNumbers.Font.Style| FontStyle.Italic);
            }
            else
            {
                txtdivisibleNumbers.Font = new Font(txtdivisibleNumbers.Font.FontFamily, txtdivisibleNumbers.Font.Size, FontStyle.Regular);
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            divisibleNumber = "";
            controlnumber = 1;
            if (txtFrom.Text == "" || txtTo.Text == "")
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else if (cmbDivisibleTerms.SelectedIndex<0)
            {
                MessageBox.Show("Please select a divisible term\n" +
                    "from the dropdown menu");
            }
            else
            {
                firstNumber = Convert.ToInt32(txtFrom.Text);
                lastNumber = Convert.ToInt32(txtTo.Text);
                for (int i = firstNumber; i <= lastNumber; i++)
                {
                    if (i % divisibleTerm == 0)
                    {
                        divisibleNumber = divisibleNumber + i.ToString() + " ";
                        if (controlnumber % 10 == 0)
                            divisibleNumber += Environment.NewLine;
                        controlnumber += 1;
                    }
                }
                txtdivisibleNumbers.Text=divisibleNumber;
            }
        }
    }
}
