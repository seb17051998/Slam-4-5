using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpPOOHeritage
{
    class Lion:Félin
    {
        
        public Lion(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, int nombrePattes):base(nom,LieuHabitation,monCrie,jeSuisDomestique,nombrePattes)
        {
            
            this.JeSuisDangereux();
        }

        public void Afficher()
        {
            Console.WriteLine(" Nom: {0} \n LieuHabitation: {1} \n Cri: {2} \n Animal domestique : {3} \n Dangereux: {4} \n Nombres de pattes: {5}", GetNom(), GetLieuHabitation(), GetMonCrie(), GetJeSuisDomestique(), JeSuisDangereux(), GetNombrepattes());
        }
    }
}
