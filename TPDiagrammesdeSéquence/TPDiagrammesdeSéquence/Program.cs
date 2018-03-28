using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TPDiagrammesdeSéquence
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciation
            Catalogue c = new Catalogue();
            Article a = new Article("Processeur",150.0,19.6);
            Article a1 = new Article("Mémoire",30.0,19.6);
            Article a2 = new Article("carte mère",80,19.6);
            
            //Ajout dans le catalogue
            c.AjouterArticle(a);
            c.AjouterArticle(a1);
            c.AjouterArticle(a2);

            Console.ReadLine();
        }
    }
}
