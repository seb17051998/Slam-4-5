using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace concessionAutomobile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Instanciation du modèle , du véhicule */

            Modèle m = new Modèle("Clio", 12000);
            
            Vehicule v1 = new Vehicule("474qq95");
            Vehicule v = new Voiture("474qq95", m);

            /* Instanciation des options et d'une voiture*/
            Option cd = new Option("CD audio", 230);
            Option air = new Option("Air Conditionné", 395);
            Option direction= new Option("Direction assistée", 250);
            Option airBag = new Option("AirBag", 320);
            Voiture voiture = new Voiture("474qq95", m);

            /* ajout à la collection */
            m.AddOption(direction);
            m.AddOption(airBag);
            v.AddOption(cd);
            v.AddOption(air);
            v1.AddOption(cd);
            v1.AddOption(air);
            voiture.AddOption(cd);
            voiture.AddOption(air);


            /* Méthode ToString sur le modèle , le véhicule et la voiture */
            Console.WriteLine("Le modèle");
            m.ToString();
            Console.WriteLine();
        
            Console.WriteLine("le véhicule dont une voiture");
            v.ToString();
            Console.WriteLine();

            Console.WriteLine("le véhicule");
            v1.ToString();
            Console.WriteLine();

            Console.WriteLine("La voiture");
            voiture.ToString();
            Console.WriteLine();



            Console.ReadLine();


        }
    }
}
