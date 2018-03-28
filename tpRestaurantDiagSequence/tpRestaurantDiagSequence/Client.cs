using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpRestaurantDiagSequence
{
    class Client:Personne
    {
        Waiter leServeur;
        string nom;

        //Constructeur
        public Client(string n)
            : base(n)
        {
            this.nom = n;
        }
        //Méthodes
        public void ServeWind()
        {
            Console.WriteLine("enfin j'ai soif");
        }

        public void SeMetATable(Waiter unServeur)
        {
            leServeur = unServeur;
            Console.WriteLine("hep serveur");
            unServeur.OrderFood(this);
            
        }

        public void ServeFood(Cashier leCaissier)
        {
            Client leClient = new Client(nom);
            Console.WriteLine("Merci a table");
            leCaissier.Pay();
        }
    }
}
