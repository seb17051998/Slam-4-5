using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TpFenetreMereFille
{
    public partial class Mère : Form
    {
        Mère maMère;
        private List<FFille> lesFilles;
        int nombreFille;
        private string nomMere;
        
        
        public Mère()
        {
            InitializeComponent();
            this.Text = "Mère";
            this.nomMere = "Maman";
            btnNew.Click += new EventHandler(btnNew_Click);
            lesFilles = new List<FFille>();
            btnShow.Click += new EventHandler(btnShow_Click);
            btnHide.Click += new EventHandler(btnHide_Click);
            btnShowDialog.Click += new EventHandler(btnShowDialog_Click);
        }

        void btnShowDialog_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex == -1)
            {
                MessageBox.Show("Vous n'avez rien sélectionné", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.lesFilles[lbLesFilles.SelectedIndex].ShowDialog();

            }
        }

        void btnHide_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex == -1)
            {
                MessageBox.Show("Vous n'avez rien sélectionné", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbLesFilles.Items.RemoveAt(lbLesFilles.SelectedIndex);
               
            }
        }

        void btnShow_Click(object sender, EventArgs e)
        {
            if (lbLesFilles.SelectedIndex == -1)
            {
                MessageBox.Show("Vous n'avez rien sélectionné", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.lesFilles[lbLesFilles.SelectedIndex].Show();

            }
            
            
        }

        void btnNew_Click(object sender, EventArgs e)
        {
            FFille nouvellefille;
            nombreFille = nombreFille + 1;
            nouvellefille = new FFille(maMère, nombreFille);
            lesFilles.Add(nouvellefille);
            lbLesFilles.Items.Add("Fille n°" + this.nombreFille);
            nouvellefille.TextChanged += new EventHandler(nouvellefille_TextChanged);


        }

        void nouvellefille_TextChanged(object sender, EventArgs e)
        {
            FFille maFille = (FFille)sender;
            MaFilleChangeDeNom(maFille, maFille.Text);
        }

        public void MaFilleChangeDeNom(FFille ffille, string nouveauNom)
        {
            int position = lesFilles.IndexOf(ffille);
            lbLesFilles.Items[position] = nouveauNom;

            
            
        }
    }
}
