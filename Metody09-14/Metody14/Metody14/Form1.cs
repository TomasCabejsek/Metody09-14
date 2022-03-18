using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Identicke(string retezec, string retezecdva, out int pocetLisicichSePozic, out int indexPrvniOdlisnosti)
        {
            bool identika = true;

            indexPrvniOdlisnosti = -1;

            int delka;
            if (retezec.Length > retezecdva.Length)
            {
                delka = retezecdva.Length;
                pocetLisicichSePozic = retezec.Length - retezecdva.Length;
            }
            else
            {
                delka = retezec.Length;
                pocetLisicichSePozic = retezecdva.Length - retezec.Length;
            }


            for (int i = 0; i < delka; i++)
            {
                if (retezec[i] != retezecdva[i])
                {
                    identika = false;
                    ++pocetLisicichSePozic;
                    if (indexPrvniOdlisnosti == -1)
                    {
                        indexPrvniOdlisnosti = i;
                    }
                }
                
            }
            if (indexPrvniOdlisnosti == -1 && !identika)
            {
                indexPrvniOdlisnosti = delka;
            }
            if (pocetLisicichSePozic > 0)
            {
                identika = false;
            }
            return identika;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string ss = textBox2.Text;
            int indexOdl = 0;
            int pocetOdl = 0;

            if (Identicke(s, ss, out pocetOdl, out indexOdl))
            {
                MessageBox.Show("Retezce jsou identicke");
            }
            else
            {
                MessageBox.Show("Retezce jsou odlisne index prvni odlisnosti je " + indexOdl + " Pocet odlisnych je " + pocetOdl);
            }
        }
    }
}
