using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Game : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Joc.accdb");
        
        public static int admin=0;
        public Game()
        {
            InitializeComponent();
            label1.Text = "Bine ai revenit " + Start.utilizator ;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void confirmareParolaAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Confirmare conf = new Confirmare();
            conf.ShowDialog();
            if (admin == 1)
            {
                adaugareCuvinteToolStripMenuItem.Visible = true;
                listaCuvinteToolStripMenuItem.Visible = true;
                label1.Text +='\n'+ "(admin)";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Highscores hi = new Highscores();
            hi.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Joc.dificultate = "Usor";
            Joc j = new Joc();
            j.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Joc.dificultate = "Normal";
            Joc j = new Joc();
            j.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Joc.dificultate = "Greu";
            Joc j = new Joc();
            j.ShowDialog();
        }

        private void adaugareCuvinteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adaugare_cuvinte ad = new Adaugare_cuvinte();
            ad.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start.utilizator = null;
            Start.parola = null;
            Start.iduser = 0;
            this.Hide();
            Start s = new Hangman.Start();
            s.ShowDialog();
        }

        private void listaCuvinteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_Cuvinte lc = new Lista_Cuvinte();
            lc.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }
    }
}
