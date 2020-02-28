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
    public partial class Inregistrare : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Joc.accdb");

        public Inregistrare()
        {
            InitializeComponent();
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n, p, pa, u;
            n = nume.Text;
            p = prenume.Text;
            u = user.Text;
            pa = parola1.Text;
            if (nume.Text == "" || prenume.Text == "" || user.Text == "" || parola1.Text == "" || parola2.Text == "") MessageBox.Show("Introduceti toate datele.");
            else if (parola1.Text != parola2.Text) MessageBox.Show("Parolele nu corespund.");
            else
            {
                OleDbCommand inserare = new OleDbCommand("insert into Utilizatori(nume,prenume,Usern,Passw) values ('" + n + "','" + p + "','" + u + "','" + pa + "')", con);
                inserare.ExecuteNonQuery();
                MessageBox.Show("Inregistrarea a reusit.");
                this.Close();
            }
        }
    }
}
