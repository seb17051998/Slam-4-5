using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_3
{
    class Camion:Vehicule
    {
        
        protected bool semiRemorque;
        protected int essieux;

        public Camion(string immatriculation, int anneeConstruction, string marque, string modele, bool semiRemorque, int essieux)
            : base(immatriculation, anneeConstruction, marque, modele)
        {
            this.immatriculation = immatriculation;
            this.anneeConstruction = anneeConstruction;
            this.marque = marque;
            this.modele = modele;
            this.semiRemorque = semiRemorque;
            this.essieux = essieux;
        }

        public bool SemiRemorque()
        {
            if (semiRemorque == true)
            {
                Console.Write("Semi remorque");
            }
            else
            {
                Console.Write("Camion");
            }
            return semiRemorque;
        }

        public int GetEssieux()
        {
            Console.Write(" avec {0} essieux",essieux);
            return essieux;
        }

        public string ToString()
        {
            return string.Format(" {0} avec {1}\n Immatriculation: {2}\n Année de construction: {3}\n Marque: {4}\n Modèle: {5}", SemiRemorque(), essieux, immatriculation, anneeConstruction, marque, modele);
        }
    }
}
