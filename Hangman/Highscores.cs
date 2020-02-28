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
    public partial class Highscores : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Joc.accdb");

        public Highscores()
        {
            InitializeComponent();
            con.Open();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = comboBox1.Text;
            OleDbCommand scor = new OleDbCommand("select Scoruri.ID,Utilizatori.Usern,Scoruri.Dificultate,Scoruri.Scor from Utilizatori,Scoruri where Scoruri.Dificultate='" + text + "' and Utilizatori.IDUser=Scoruri.IDUser order by Scoruri.Scor DESC", con);
            OleDbDataAdapter adapt = new OleDbDataAdapter(scor);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    
    }
}
