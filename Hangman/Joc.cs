using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Joc : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Joc.accdb");
        public static string dificultate;
        private string[] word;
        private int nrgreseli = 0;
        private int scor=0;
        private string cuvant,ghicit;
        private void Blocare_Butoane()
        {
            q.Enabled = false; w.Enabled = false; e.Enabled = false; r.Enabled = false; t.Enabled = false;
            y.Enabled = false; u.Enabled = false; i.Enabled = false; o.Enabled = false; p.Enabled = false;
            a.Enabled = false; s.Enabled = false; d.Enabled = false; f.Enabled = false; g.Enabled = false;
            h.Enabled = false; j.Enabled = false; k.Enabled = false; l.Enabled = false; z.Enabled = false;
            x.Enabled = false; c.Enabled = false; v.Enabled = false; b.Enabled = false; c.Enabled = false;
            v.Enabled = false; b.Enabled = false; n.Enabled = false; m.Enabled = false;
        }
        private void Deblocare_Butoane()
        {
            q.Enabled = true; w.Enabled = true; e.Enabled = true; r.Enabled = true; t.Enabled = true;
            y.Enabled = true; u.Enabled = true; i.Enabled = true; o.Enabled = true; p.Enabled = true;
            a.Enabled = true; s.Enabled = true; d.Enabled = true; f.Enabled = true; g.Enabled = true;
            h.Enabled = true; j.Enabled = true; k.Enabled = true; l.Enabled = true; z.Enabled = true;
            x.Enabled = true; c.Enabled = true; v.Enabled = true; b.Enabled = true; c.Enabled = true;
            v.Enabled = true; b.Enabled = true; n.Enabled = true; m.Enabled = true;
        }
        private void Colorare_Butoane()
        {
            q.BackColor=Color.DarkTurquoise; w.BackColor=Color.DarkTurquoise; e.BackColor=Color.DarkTurquoise; r.BackColor=Color.DarkTurquoise; t.BackColor=Color.DarkTurquoise;
            y.BackColor=Color.DarkTurquoise; u.BackColor=Color.DarkTurquoise; i.BackColor=Color.DarkTurquoise; o.BackColor=Color.DarkTurquoise; p.BackColor=Color.DarkTurquoise;
            a.BackColor=Color.DarkTurquoise; s.BackColor=Color.DarkTurquoise; d.BackColor=Color.DarkTurquoise; f.BackColor=Color.DarkTurquoise; g.BackColor=Color.DarkTurquoise;
            h.BackColor=Color.DarkTurquoise; j.BackColor=Color.DarkTurquoise; k.BackColor=Color.DarkTurquoise; l.BackColor=Color.DarkTurquoise; z.BackColor=Color.DarkTurquoise;
            x.BackColor=Color.DarkTurquoise; c.BackColor=Color.DarkTurquoise; v.BackColor=Color.DarkTurquoise; b.BackColor=Color.DarkTurquoise; c.BackColor=Color.DarkTurquoise;
            v.BackColor=Color.DarkTurquoise; b.BackColor=Color.DarkTurquoise; n.BackColor=Color.DarkTurquoise; m.BackColor=Color.DarkTurquoise;
        }
        private void Greseala()
        {
            nrgreseli++;
            pictureBox1.Load("Imagini\\" + nrgreseli.ToString() + ".jpg");
        }
        private void IncarcareCuvinte()
        {

            string[] temp = File.ReadAllLines("Cuvinte\\" + dificultate + ".txt");
            word = new string[temp.Length];
            int index = 0;
            foreach(string s in temp)
            { word[index++] = s; }
        }          
        private void GetWord()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, word.Length);
            cuvant = word[index];
            ghicit = "";
           // MessageBox.Show(cuvant + " " + cuvant.Length.ToString());
            for (int i = 0; i < cuvant.Length; i++) ghicit += "_";
            AfisareGhicit();
        }
        private void AfisareGhicit()
        {
            label3.Text = "";
            for (int i = 0; i < ghicit.Length; i++)
            {
                label3.Text += ghicit.Substring(i, 1);
                label3.Text += " ";
            }
        }
        private void Verifica()
        {
            if (ghicit.Equals(cuvant))
            {
                MessageBox.Show("Cuvant ghicit");
                button1.Visible = true;
                scor++;
                Blocare_Butoane();
            }
        }
        private void GameOver()
        {
            MessageBox.Show("Joc terminat."+'\n'+"Cuvantul era:"+cuvant);
            MessageBox.Show("Scor final:" + scor);
            Blocare_Butoane();
            this.Close();
            int idu = Start.iduser;
            OleDbCommand adauga = new OleDbCommand("insert into Scoruri(IDUser,Dificultate,Scor) values('" + idu + "','" + dificultate + "','" + scor + "')", con);
            adauga.ExecuteNonQuery();
        }        
        public Joc()
        {
            InitializeComponent();
            IncarcareCuvinte();
            string text = "Dificultate:" + dificultate;
            this.label1.Text += dificultate ;
            this.label2.Text += scor.ToString();
            pictureBox1.Load("Imagini\\" + nrgreseli.ToString() + ".jpg");
            GetWord();
            con.Open();
        }
        
        private void Joc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetWord();
            nrgreseli = 0;
            pictureBox1.Load("Imagini\\0.jpg");
            label2.Text = "Scor:" + scor.ToString();
            Deblocare_Butoane();
            Colorare_Butoane();
            button1.Visible = false;
        }
        private void buton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (cuvant.Contains(btn.Text))
            {
                char[] temp = ghicit.ToCharArray();
                char[] litere = cuvant.ToCharArray();
                char litera = Convert.ToChar(btn.Text);
                for (int i = 0; i < litere.Length; i++)
                {
                    if (litere[i] == litera) temp[i] = litera;
                }
                ghicit = new string(temp);
                AfisareGhicit();
                btn.BackColor = Color.Green;
                btn.Enabled = false;
            }
            else
            {
                Greseala();
                btn.BackColor = Color.Red;
                btn.Enabled = false;
            }
            if(nrgreseli>=6)
            { GameOver(); }
            Verifica();
        }
    }
}
