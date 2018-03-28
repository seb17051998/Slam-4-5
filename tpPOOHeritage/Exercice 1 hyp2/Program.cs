using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpPOOHeritage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Baleine> lesBaleines = new List<Baleine>(); 
            List<Cétacé> lesCétacés = new List<Cétacé>(); 
            List<Chat> lesChats = new List<Chat>(); 
            List<Lion> lesLions = new List<Lion>(); 
            List<Félin> lesFélins = new List<Félin>(); 
            List<Mammifère> lesMammifères= new List<Mammifère>();


            Mammifère m1 = new Mammifère("monMammifere", "Terre", "", true);
            Félin f1 = new Félin("monFelin", "Terrestre", "", false, 4);
            Cétacé ce1 = new Cétacé("monCetace", "Aquatique", "", false, 50, 1000);
            Lion l1 = new Lion("Tracy", "Jungle", "ROOOOOO", false, 4);
            lesFélins.Add((Lion)l1);
            lesMammifères.Add((Lion)l1);
            lesLions.Add((Lion)l1);
            Lion l2 = new Lion("Méloée", "Jungle", "ROOOOOO", false, 4);
            lesMammifères.Add((Lion)l2);
            lesFélins.Add((Lion)l2);
            lesLions.Add((Lion)l2);
            Chat c1 = new Chat("Kenza", "Rue", "MIAOU", true, 4);
            lesMammifères.Add((Chat)c1);
            lesFélins.Add((Chat)c1);
            lesChats.Add((Chat)c1);
            Chat c2 = new Chat("Pauline", "Rue", "MIAOU", true, 4);
            lesMammifères.Add((Chat)c2);
            lesFélins.Add((Chat)c2);
            lesChats.Add((Chat)c2);
            Baleine b1 = new Baleine("Mobidick", "Océan", "MHHH", false, 90, 1000);
            lesMammifères.Add((Baleine)b1);
            lesCétacés.Add((Baleine)b1);
            lesBaleines.Add((Baleine)b1);
            Baleine b2 = new Baleine("Bernard", "Abysses", "MHHHHH", false, 8000, 3000);
            lesMammifères.Add((Baleine)b2);
            lesCétacés.Add((Baleine)b2);
            lesBaleines.Add((Baleine)b2);

            
            int choix;
            bool repeat=false;
            while (repeat == false)
            {
                
                Console.WriteLine("");
                Console.WriteLine("1- Félin");
                Console.WriteLine("2- Cétacé");
                Console.WriteLine("3- Quitter");
                Console.WriteLine("4- Nombres d'animaux total");
                Console.WriteLine("5- Liste des animaux");
                Console.WriteLine("Votre choix : ");
                
                choix = Convert.ToInt32(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        int choix2;

                        Console.WriteLine("1- Dangeureux");
                        Console.WriteLine("2- Inoffensif");
                        Console.WriteLine("3- Nombres de Félins");
                        Console.WriteLine("4- Nombres de Cétacés");
                        Console.WriteLine("Votre choix : ");
                        choix2 = Convert.ToInt32(Console.ReadLine());
                        switch (choix2)
                        {
                            case 1:
                                int choix21;
                                Console.WriteLine("Nous avons {0} lions",lesLions.Count);
                                Console.WriteLine("1- Tracy");
                                Console.WriteLine("2- Méloée");
                                choix21 = Convert.ToInt32(Console.ReadLine());
                                switch (choix21)
                                {
                                    case 1:
                                        l1.Afficher();
                                        break;
                                    case 2:
                                        l2.Afficher();
                                        break;
                                    
                                }
                                break;
                            case 2:
                                int choix22;
                                Console.WriteLine("Nous avons {0} chats",lesChats.Count);
                                Console.WriteLine("1- Kenza");
                                Console.WriteLine("2- Pauline");
                                choix22 = Convert.ToInt32(Console.ReadLine());
                                switch (choix22)
                                {
                                    case 1:
                                        c1.Afficher();
                                        break;
                                    case 2:
                                        c2.Afficher();
                                        break;
                                }
                                break;
                            case 3:
                                Console.WriteLine("Il y a {0} Félins au total dont {1} qui sont dangeureux", lesFélins.Count, lesLions.Count);
                                break;
                            

                        }
                        break;

                    case 2:
                        int choix3;
                        Console.WriteLine("Nous avons {0} baleine",lesBaleines.Count);
                        Console.WriteLine("1- Mobitic");
                        Console.WriteLine("2- Bernard");
                        choix3 = Convert.ToInt32(Console.ReadLine());
                        switch (choix3)
                        {
                            case 1:
                                b1.Afficher();
                                break;
                            case 2:
                                b2.Afficher();
                                break;
                        }
                        break;
                    case 3:
                        repeat = true;
                        break;
                    case 4:
                        Console.WriteLine("Il y a au total {0} animaux en stock",lesMammifères.Count);
                        break;
                    case 5:
                        for (int a = 0; a < lesMammifères.Count; a++)
                        {
                            Console.WriteLine("Espèce :"+lesMammifères[a].GetType()+"\n "+lesMammifères[a].ToString());
                            Console.WriteLine(" ");
                        }
                        break;
                        


                }
            }


            

            /*l1.JeSuisDangereux();
            l1.Afficher();
            Console.WriteLine("");
            c1.Afficher();
            Console.WriteLine("");
            b1.Afficher(); */

            


            Console.ReadLine();
        }
    }
}
