using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace concessionAutomobile
{
    class Voiture : Vehicule
    {
        Modèle possède;
        

        public Voiture(string immatriculation, Modèle possède)
            : base(immatriculation)
        {
            this.possède = possède;
            
        }

        public double CalculerPrix()
        {
            double prix = 0;
            prix = this.possède.GetPrix;
            for (int i = 0; i < this.possède.Count; i++)
            {
                prix = prix + this.possède[i].GetPrix();
            }

            for (int i = 0; i < this.count; i++)
            {
                prix = prix + this[i].GetPrix();
            }
            return prix;
        }

        public new string ToString()
        {
            Console.Write("{0}",this.possède.ToString());           
            base.ToString();
            Console.WriteLine("Prix total : {0} Euros",CalculerPrix());

            
            return string.Format("");
        }
    }
}
