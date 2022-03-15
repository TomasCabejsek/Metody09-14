using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private int PocetSlov(string retezec, out string bezCislic)
        {
            char[] oddelovace = { ' ' };
            string[] poleSlov = retezec.Split(oddelovace, StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            while (i < retezec.Length)
            {
                if (Char.IsDigit(retezec[i]))
                {
                    retezec = retezec.Remove(i, 1);
                }
                else --i;
                ++i;
            }
            bezCislic = retezec;
            return poleSlov.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string bezCislic;
            PocetSlov(s, out bezCislic);
            MessageBox.Show("Pocet slov je " + PocetSlov(s, out bezCislic) + "Veta vypada takhle bez cislic " + bezCislic);

        }
    }
}
