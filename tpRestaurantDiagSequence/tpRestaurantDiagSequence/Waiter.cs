using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpRestaurantDiagSequence
{
    class Waiter:Personne
    {
        Cook monCuisinier;
        Client monClient;
        Cashier leCaissier;
        
            
        string nom;
        

        //constructeur
        public Waiter(Cook unCuisinier, Cashier leCaissier, string n):base(n)
        {
            this.leCaissier=leCaissier;
            this.monCuisinier = unCuisinier;
            this.nom = n;
            
            
        }
        //Méthodes
        public void OrderFood(Client monClient)
        {
            this.monClient = monClient;
            Waiter unServeur = new Waiter(monCuisinier, leCaissier, nom);
            Console.WriteLine("à votre dispo que voulez vous ?");
            monCuisinier.OrderFood(this);
            
            
        }

        public void PickUP()
        {
            this.monClient.ServeWind();
            this.monClient.ServeFood(this.leCaissier);
        }
    }
}
