using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkylator_by_vlad_edition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            if (textBox1.Text[textBox1.TextLength - 1] == '=') return;
            textBox1.Text += "=";

        }

        private void button0_Click(object sender, EventArgs e)
        {

            textBox1.Text +=  0;
        }

        private void button01_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }

        private void button02_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button03_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button04_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button05_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button06_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button07_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button08_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button09_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            
            if (textBox1.TextLength == 0) return;
            if (textBox1.Text[textBox1.TextLength - 1] == '+') return;
            if (textBox1.Text[textBox1.TextLength - 1] == '*') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '-') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '/') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '^') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == ')') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '(') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '.') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);

            textBox1.Text +=  "+" ;
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            if (textBox1.Text[textBox1.TextLength - 1] == '-') return;
            if (textBox1.Text[textBox1.TextLength - 1] == '*') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '/') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '+') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '^') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == ')') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '(') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '.') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            textBox1.Text += "-";
        }

        private void buttonymn_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            if (textBox1.Text[textBox1.TextLength - 1] == '*') return;
            if (textBox1.Text[textBox1.TextLength - 1] == '/') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '-') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '+') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '^') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == ')') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '(') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '.') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);

            textBox1.Text += "*";
        }

        private void buttondelenie_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            if (textBox1.Text[textBox1.TextLength - 1] == '/') return;
            if (textBox1.Text[textBox1.TextLength - 1] == '*') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '-') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '+') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '^') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == ')') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '(') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '.') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            textBox1.Text += "/";
        }

        private void buttonkvadrat_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            if (textBox1.Text[textBox1.TextLength - 1] == '/') return;
            if (textBox1.Text[textBox1.TextLength - 1] == '*') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '-') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '+') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '^') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == ')') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '(') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '.') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            textBox1.Text += "^";
        }

        private void buttonskobkaotkrilas_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            if (textBox1.Text[textBox1.TextLength - 1] == '(') return;
            if (textBox1.Text[textBox1.TextLength - 1] == '*') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '-') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '+') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '^') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == ')') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '/') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '.') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            textBox1.Text += "(";
        }

        private void buttonskobkazakrilas_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            if (textBox1.Text[textBox1.TextLength - 1] == ')') return;
            if (textBox1.Text[textBox1.TextLength - 1] == '*') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '-') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '+') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '^') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '/') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '(') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            if (textBox1.Text[textBox1.TextLength - 1] == '.') textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            textBox1.Text += ")";
        }
        private void buttonpoint_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0 
                || textBox1.Text[textBox1.TextLength - 1] == '*'
                || textBox1.Text[textBox1.TextLength - 1] == '-'
                || textBox1.Text[textBox1.TextLength - 1] == '-'
                || textBox1.Text[textBox1.TextLength - 1] == '+'
                || textBox1.Text[textBox1.TextLength - 1] == '/'
                || textBox1.Text[textBox1.TextLength - 1] == ')'
                || textBox1.Text[textBox1.TextLength - 1] == '('
                || textBox1.Text[textBox1.TextLength - 1] == '^'
                )
            {
                textBox1.Text += "0.";
                return;
            }
            

            if (textBox1.Text[textBox1.TextLength - 1] == '.') return;
 
            textBox1.Text += ".";
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; 
        }

        private void buttonb_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0) return;
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }
        
        
        
        
        
        
        
        
        
        
        
    }
}