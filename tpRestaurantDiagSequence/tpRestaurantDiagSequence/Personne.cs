using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpRestaurantDiagSequence
{
    class Personne
    {
        private string nom;

        public Personne(string n)
        {
            this.nom = n;
        }

        public string GetNom()
        {
            return nom;
        }
    }
}
