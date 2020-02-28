using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hangman
{
    public partial class Lista_Cuvinte : Form
    {
        private void IncarcaCuvinte()
        { 
            StreamReader sr1 = new StreamReader("Cuvinte\\Usor.txt");
            StreamReader sr2 = new StreamReader("Cuvinte\\Normal.txt");
            StreamReader sr3 = new StreamReader("Cuvinte\\Greu.txt");
            string u = sr1.ReadToEnd(), n = sr2.ReadToEnd(), g = sr3.ReadToEnd();
            string[] usor = u.Split('\n'), normal = n.Split('\n'), greu = g.Split('\n');
            foreach (string cuv in usor) listBox1.Items.Add(cuv);
            foreach (string cuv in normal) listBox2.Items.Add(cuv);
            foreach (string cuv in greu) listBox3.Items.Add(cuv);
            sr1.Dispose();
            sr2.Dispose();
            sr3.Dispose();
        }
        public Lista_Cuvinte()
        {
            InitializeComponent();
            IncarcaCuvinte();
        }

        private void Lista_Cuvinte_Load(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
