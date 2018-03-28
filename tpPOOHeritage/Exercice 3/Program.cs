using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicule[] Tab = new Vehicule[4];
            Tab[0] = new Voiture(
                "333 ABC 06",
                2000,
                "peugeot",
                "306",
                true,
                false);
            Tab[1] = new Voiture(
                "321 BBD 06",
                2001,
                "renault",
                "clio",
                false,
                true);
            Tab[2] = new Camion(
                "1234 TZ 06",
                 1993,
                "DAF",
                "T43",
                true,
                4);
            Tab[3] = new Camion(
                "765 ACE 06",
                1999,
                "Mercedes",
                "C.L",
                false,
                3);

            for (int i = 0; i < Tab.Length; i++)
            {
                //Console.WriteLine(Tab[i].ToString());
                if (Tab[i] is Voiture)
                {
                    ((Voiture)Tab[i]).Decapotable();
                    ((Voiture)Tab[i]).Climatisation();
                }
                if (Tab[i] is Camion)
                {
                    ((Camion)Tab[i]).SemiRemorque();
                    ((Camion)Tab[i]).GetEssieux();
                }
                    Console.WriteLine(Tab[i].ToString());
                
            }

            Console.ReadLine();
        }
    }
}
