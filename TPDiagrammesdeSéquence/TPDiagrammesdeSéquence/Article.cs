using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_1_Correction
{
    public partial class Article
    {
        private string designation;
        private double prixHorsTaxe;
        private double tauxTva;

        public Article(string designation, double prixHorsTaxe, double tauxTva)
        {
            this.designation = designation;
            this.prixHorsTaxe = prixHorsTaxe;
            this.tauxTva = tauxTva;
        }

        public double GetPrixHorsTaxe
        {
            get { return prixHorsTaxe; }
            set { prixHorsTaxe = value; }
        }

        public string GetDesignation
        {
            get { return designation; }
            set { designation = value; }
        }


    }
}
