using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool JeAlfanum(string retezec, out int pocetMalychPismen, out int pocetVelkychPismen, out int pocetJinychZnaku)
        {
            bool jeAlfanumericky = true;
            pocetJinychZnaku = 0;
            pocetMalychPismen = 0;
            pocetVelkychPismen = 0;
            for (int i = 0; i < retezec.Length; i++)
            {
                if (Char.IsLetterOrDigit(retezec[i]))
                {
                    if (Char.IsUpper(retezec[i]))
                    {
                        ++pocetVelkychPismen;
                    }
                    else if (Char.IsLower(retezec[i]))
                    {
                        ++pocetMalychPismen;
                    }
                }
                else
                {
                    ++pocetJinychZnaku;
                    jeAlfanumericky = false;
                }
            }
            return jeAlfanumericky;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int pocetMalPis = 0;
            int pocetVelPis = 0;
            int pocetJinych = 0;

            if (JeAlfanum(s, out pocetMalPis, out pocetVelPis, out pocetJinych))
            {
                MessageBox.Show("Ano retezec je alfanumericky obsahuje jen cislice a pismena \nPocet malych pismen je " + pocetMalPis + "\nPocet velkych pismen je " + pocetVelPis);
            }
            else
            {
                MessageBox.Show("Ne retezec neni alfanumericky obsahuje cislice, pismena a jine znaky \nPocet malych pismen je " + pocetMalPis + "\nPocet velkych pismen je " + pocetVelPis + "\nPocet jinych znaku je " + pocetJinych);
            }
        }
    }
}
