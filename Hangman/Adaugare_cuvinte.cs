using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Adaugare_cuvinte : Form
    {
        private string text;
        private void Incarcare()
        {
            FileStream f = new FileStream("Cuvinte\\" + dificultate.Text + ".txt", FileMode.Open);
            StreamReader sr = new StreamReader(f);
            text = sr.ReadToEnd();
            sr.Dispose();
        }
        private void Adauga()
        {
            StreamWriter sw = new StreamWriter(@"Cuvinte\\" + dificultate.Text + ".txt");
            text += '\n' + cuvant.Text;
            sw.Write(text);
            sw.Dispose();
        }

        public Adaugare_cuvinte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dificultate.Text == "") MessageBox.Show("Alegeti dificultatea.");
            else if (cuvant.Text == "") MessageBox.Show("Scrieti un cuvant.");
            else try
                {
                    Incarcare();
                    Adauga();
                    MessageBox.Show("Cuvant adaugat");
                }
                catch(Exception ex)
                { MessageBox.Show(ex.Message); }
        }
    }
}
