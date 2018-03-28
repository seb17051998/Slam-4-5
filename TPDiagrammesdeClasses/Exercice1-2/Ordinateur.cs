using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice1_2
{
    class Ordinateur
    {
        private string nom;
        private string puissance;
        private int tailleMemoire;
        private Personne utilisateur;
        private FileDattente laFileDattente;


        public Ordinateur(string nom, string puissance, int tailleMemoire, Personne unUtilisateur) {
            laFileDattente = new FileDattente();
            this.nom=nom;
            this.puissance = puissance;
            this.tailleMemoire = tailleMemoire;
            this.utilisateur = unUtilisateur;

        }
        public bool Allumer() { }
        public bool Eteindre() { }
    }
}
