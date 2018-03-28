using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TpBibliotheque
{
    class Bibliotheque
    {
        //private List<Bibliotheque> uneBibliotheque;
        private string nomBibliotheque;
        private string ville;
        private string dirigeant;
        


        public Bibliotheque(string nomBibliotheque,string ville, string dirigeant)
        {
            this.nomBibliotheque = nomBibliotheque;
            this.ville=ville;
            this.dirigeant = dirigeant;
            //uneBibliotheque.Add();
        }
        public Genre GetGenre(string libelleGenre)
        {
            return 
        }
        public Livre NouveauLivre(string titre, string libelleGenre)
        {
            Livre nouveauLivre;
            Genre unGenre = this.GetGenre(libelleGenre);
            if (unGenre == null)
            {
                nouveauLivre = null;
            }
            else
            {
                nouveauLivre = new Livre(titre, unGenre);
                unGenre.PlaceLivre(nouveauLivre);
            }
            return nouveauLivre;
        }

        public Add(Etagere e)
        {
            e=new Etagere(
        }
    }
}
