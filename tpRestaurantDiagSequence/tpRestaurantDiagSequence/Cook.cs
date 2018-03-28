using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpRestaurantDiagSequence
{
    class Cook:Personne
    {
        string nom;

        public Cook(string n)
            : base(n)
        {
            this.nom = n;
        }
        public void OrderFood(Waiter unServeur)
        {
            Console.WriteLine("Plat du jour,ça marche");
            unServeur.PickUP();
        }
    }
}
