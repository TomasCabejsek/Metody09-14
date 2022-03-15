using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ObsahujeCislici(string retezec, out int cifSoucet, out int soucetLichCifer, out int soucetSudCifer)
        {
            bool obsahuje = false;
            cifSoucet = 0;
            soucetLichCifer = 0;
            soucetSudCifer = 0;

            char[] poleCifer = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            for (int i = 0; i < retezec.Length; i++)
            {
                char znak = retezec[i];
                if (poleCifer.Contains(znak))
                {
                    int cifra = int.Parse(znak.ToString());
                    cifSoucet += cifra;
                    obsahuje = true;
                    if (znak % 2 == 0)
                    {
                        soucetSudCifer += cifra;
                    }
                    else
                    {
                        soucetLichCifer += cifra;
                    }
                }
            }
            return obsahuje;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int cifSoucet;
            int soucetLichCifer;
            int soucetSudCifer;
            if (ObsahujeCislici(s, out cifSoucet, out soucetLichCifer, out soucetSudCifer))
            {
                MessageBox.Show("Ano obsahuje cislici, Soucet cifer je " + cifSoucet + ", Soucet lichych cifer je " + soucetLichCifer + ", Soucet sudych cifer je " + soucetSudCifer);
            }
            else
            {
                MessageBox.Show("Neobsahuje cislici");
            }
            
        }
    }
}
