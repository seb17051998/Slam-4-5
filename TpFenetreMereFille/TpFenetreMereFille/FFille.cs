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
    public partial class FFille : Form
    {
        private string monNom;
        private Mère maMere;
        private int numero;
        
        
        

        public FFille(Mère MaMere, int numero)
        {
            InitializeComponent();
            this.Text = "Fille n°" + numero;
            this.monNom = this.Text;
            this.maMere = maMere;
            
            this.btnMaMere.Click += new EventHandler(btnMaMere_Click);
            this.tbNomFille.TextChanged += new EventHandler(tbNomFille_TextChanged);
      
        }

        void tbNomFille_TextChanged(object sender, EventArgs e)
        {
            this.Text = tbNomFille.Text;
        }

      

        void btnMaMere_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La mère de "+ monNom+" s'appelle "+maMere);
        }

        void btnChanger_Click(object sender, EventArgs e)
        {
            monNom = tbNomFille.Text;
            MessageBox.Show("La fille n°"+ this.Text + " à changé de nom et s'appelle " +monNom);
            this.Text = monNom;
            //maMere.MaFilleChangeDeNom(
                
        }

        /*private void FFille_FormClosing(object sender, FormClosingEventArgs e)
        {
            FFille lafille = new FFille(this.maMere, this.numero);
            if (lafille.ShowDialog(this))
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }*/
    }
}
