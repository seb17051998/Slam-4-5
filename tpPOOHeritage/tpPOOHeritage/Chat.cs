using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpPOOHeritage
{
    class Chat:Félin
    {
        protected string espece;

        public Chat(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, int nombrePattes):base(nom,LieuHabitation,monCrie,jeSuisDomestique,nombrePattes)
        {
            this.espece = "Chat";
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
            this.nombrePattes = nombrePattes;
            
        }

        public void Afficher()
        {
            Console.WriteLine("Espece: {6}, Nom: {0} \n LieuHabitation: {1} \n Cri: {2} \n Animal domestique : {3} \n Dangereux: {4} \n Nombres de pattes: {5}", nom, LieuHabitation, monCrie, jeSuisDomestique, JeSuisDangereux(), nombrePattes,espece);
        }
    }
}
