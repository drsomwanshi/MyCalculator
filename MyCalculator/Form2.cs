using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string num = "";
        int n1, n2, ans;
        string op = "";

        private void button16_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToInt32(label1.Text);
            switch (op)
            {
                case "+":
                    ans = n1 + n2;
                    break;
                case "-":
                    ans = n1 - n2;
                    break;
                case "/":
                    ans = n1 / n2;
                    break;
                case "*":
                    ans = n1 * n2;
                    break;
                   

            }
            label1.Text = "" + ans;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string n = label1.Text; //1234
            if (n.Length > 0)
            {
                n = n.Substring(0, n.Length - 1); //4-1 =3
                label1.Text = n;
                num = label1.Text;
            }
        }

        private void OpBtnClik(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            op=btn.Text.Trim();
            n1 =Convert.ToInt32(label1.Text);
            num = "";
        }

       
        private void NumBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            num=num+btn.Text.Trim();
            label1.Text=num;
        }
    }
}
