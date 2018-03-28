using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpRestaurantDiagSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client("Julie");
            Cashier caisse= new Cashier("Mohammed");
            Cook cuisinier=new Cook("Antoine");
            Waiter s = new Waiter(cuisinier,caisse,"Sylvain");
            


            c.SeMetATable(s);
            
            Console.ReadLine();

        }
    }
}
