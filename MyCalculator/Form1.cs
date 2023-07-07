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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        string num = "";
        private void NumBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            num=num+btn.Text.Trim();
            label1.Text=num;
        }
        int n1, n2, ans;

        private void button12_Click(object sender, EventArgs e)
        {
            n2=int.Parse(label1.Text );
            num = "";
            switch (op)
            {
                case "+":
                    ans=n1+ n2;
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
            label1.Text = ans.ToString();
        }

        string op = "";
        private void OpBtnClick(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            op= bt.Text.Trim();
            n1=int.Parse(label1.Text);
            num = "";
        }
    }
}
