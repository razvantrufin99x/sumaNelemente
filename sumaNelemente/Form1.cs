using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumaNelemente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool par(int x)
        {

            if (x % 2 == 0) return true;
            else return false;

        }
        public int mijlocul(int x)
        {
            if (par(x) == true)
            {
                return x / 2;
            }
            else
            {
                return x / 2 + 1;
            }

        }

        public int sumaN(int n)
        {
            bool epar = par(n);
            int mijloc = mijlocul(n);
            int perechi = n / 2;

            if (epar == true) { return perechi * (1 + n); }
            else { return perechi * (1 + n) + mijlocul(n); }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(textBox1.Text);
            textBox2.Text += "\r\n" + sumaN(x).ToString();
        }
    }
}
