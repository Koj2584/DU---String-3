using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DU___String_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vstup = textBox1.Text;
            string cisla = "0123456789";
            string pismena = "abcdefghijklmnopqrstuvwxyzěščřžýáíéúů";

            textBox1.Text = vstup.Substring(0, vstup.Length / 2) + vstup.Last() + vstup.Substring(vstup.Length / 2);

            vstup = vstup.ToLower();

            vstup = vstup.Trim();

            while (vstup.Contains("  "))
                vstup = vstup.Replace("  ", " ");

            string[] slova = vstup.Split(' ');

            int slov = slova.Length,cifer = 0, pismen = 0, delka = 0;
            string nejdelsi = "";
            foreach(string slovo in slova)
            {
                foreach(char pismeno in slovo)
                {
                    if (cisla.Contains(pismeno))
                        cifer++;
                    if (pismena.Contains(pismeno))
                        pismen++;
                }
                if(slovo.Length > delka)
                {
                    delka = slovo.Length;
                    nejdelsi = slovo;
                }
            }

            

            label1.Text = "Pocet slov: " + slov;
            label2.Text = "Pocet cifer: " + cifer;
            label3.Text = "Pocet pismen: " + pismen;
            label4.Text = "Nejdelší slovo: " + nejdelsi;
        }
    }
}
