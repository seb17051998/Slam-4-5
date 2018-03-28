using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpRestaurantDiagSequence
{
    class Cashier:Personne
    {
        string nom;

        public Cashier(string n)
            : base(n)
        {
            this.nom = n;
        }
        public void Pay()
        {
            Console.WriteLine("par ici la monnaie");
        }
    }
}
