using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resebokning
{
    public partial class Form1 : Form
    {
        Resa[] resor = new Resa[1000];
        int antalresor = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void tbxSökKund_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBoka_Click(object sender, EventArgs e)
        {
            string kund = tbxKund.Text;
            string destination = tbxDestination.Text;
            int antalDagar = int.Parse(tbxAntalDagar.Text);

            Resa nyresa = new Resa(kund, destination, antalDagar);
            resor[antalresor++] = nyresa;

            MessageBox.Show("Resa bokad");

          

            
        }

        private void btnSök_Click(object sender, EventArgs e)
        {

            string sökKund = tbxSökKund.Text;

            for(int i=0; i<antalresor; i++)
            {
                if(resor[i].Kund == sökKund)
                {
                    lbxSökResultat.Items.Add(resor[i]);
                }
            }
            
        }

        private void btnRensa_Click(object sender, EventArgs e)
        {
            lbxSökResultat.Items.Clear();
        }
    }
}
