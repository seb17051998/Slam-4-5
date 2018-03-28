using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice_1_Correction
{
    public class Catalogue
    {
        // déclaration de la collection d'articles
        private List<Article> leCatalogue;

        public Catalogue()
        {
            leCatalogue = new List<Article>();
        }

        public void AjouterArticle(Article unArticle)
        {
            leCatalogue.Add(unArticle);
        }

        public void AugmenterPetitPrix(Article unArticle,double pourcentageAugmentation ,double prixHorsTaxe,double tauxTva)
        {
            double result;
            double prixHorsTaxe2;
            result = prixHorsTaxe;
            prixHorsTaxe = prixHorsTaxe * pourcentageAugmentation / 100;
            result = result + prixHorsTaxe;
            prixHorsTaxe2 = result ;
            result = result * tauxTva / 100;
            prixHorsTaxe2 = prixHorsTaxe2 + result;
            //result = prixHorsTaxe;
            //prixHorsTaxe = prixHorsTaxe * tauxTva / 100;
            //result = result + prixHorsTaxe;
            Console.WriteLine("Le prix TTC de l'article {0} est de {1} Euros",unArticle,prixHorsTaxe2);
            
        }

        public void AfficherCatalogue()
        {

        }
    }
}
