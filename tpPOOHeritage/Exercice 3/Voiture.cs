using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_3
{
    class Voiture:Vehicule
    {
        //private string immatriculation;
        //private int anneeConstruction;
        //private string marque;
        //private string modele;
        protected bool decapotable;
        protected bool climatisation;

        public Voiture(string immatriculation, int anneeConstruction, string marque, string modele, bool decapotable, bool climatisation):base(immatriculation,anneeConstruction,marque,modele)
        {
            this.immatriculation = immatriculation;
            this.anneeConstruction = anneeConstruction;
            this.marque = marque;
            this.modele = modele;
            this.decapotable = decapotable;
            this.climatisation = climatisation;
        }

        public bool Decapotable()
        {
            if (decapotable == true)
            {
                Console.Write("Voiture décapotable ");
            }
            else
            {
                Console.Write("Voiture Non décapotable ");
            }
            return decapotable;
        }

        public bool Climatisation()
        {
            if (climatisation == true)
            {
                Console.Write(" Avec climatisation");
            }
            else
            {
                Console.Write(" Sans climatisation");
            }

            return climatisation;

        }

        public string ToString()
        {
            return string.Format(" {0} {1}\n Immatriculation: {2}\n Année de construction: {3}\n Marque: {4}\n Modèle: {5}", Decapotable(), Climatisation(), immatriculation, anneeConstruction, marque, modele);
        }
    }
}
