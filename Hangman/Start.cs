using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Hangman
{
    public partial class Start : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Joc.accdb");
        public static string utilizator;
        public static string parola;
        public static int iduser;
        public Start()
        {
            InitializeComponent();
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Text == "" || pass.Text == "") MessageBox.Show("Introduce-ti toate datele.");
            else
            {
                utilizator = user.Text;
                parola = pass.Text;
                bool aute = false;
                try
                {
                    OleDbCommand comUtiliz = new OleDbCommand("select * from Utilizatori", con);
                    OleDbDataAdapter adapt = new OleDbDataAdapter(comUtiliz);
                    DataTable utiliz = new DataTable();
                    adapt.Fill(utiliz);
                    foreach (DataRow r in utiliz.Rows)
                        if (r["Usern"].ToString() == utilizator && r["Passw"].ToString() == parola)
                        {
                            iduser = Convert.ToInt32(r["IDUser"]);
                            aute = true;
                            MessageBox.Show("Autentificare reusita.");
                            Game g = new Hangman.Game();
                            this.Hide();
                            g.Activate();
                            g.ShowDialog();
                            break;
                        }
                    if (aute == false)
                    {
                        MessageBox.Show("Autentificare esuata.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inregistrare inr = new Inregistrare();
            inr.ShowDialog();
        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

