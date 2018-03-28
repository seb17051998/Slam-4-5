using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_1_Correction
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue unCatalogue = new Catalogue();
            Article unProcesseur = new Article("Processeur", 150.0, 19.6);
            Article Mémoire = new Article("Mémoire", 30.0, 19.6);
            Article CarteMere = new Article("Carte mère", 89, 19.6);
            unCatalogue.AjouterArticle(unProcesseur);
            unCatalogue.AjouterArticle(Mémoire);
            unCatalogue.AjouterArticle(CarteMere);
            unCatalogue.AugmenterPetitPrix(10);
        }
    }
}
