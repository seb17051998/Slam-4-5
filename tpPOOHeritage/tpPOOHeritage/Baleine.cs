using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpPOOHeritage
{
    class Baleine:Cétacé
    {
       
        public Baleine(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, int DuréeApnée, int ProfondeurPlongée)
            : base(nom, LieuHabitation, monCrie, jeSuisDomestique, DuréeApnée, ProfondeurPlongée)
        {
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
            this.DuréeApnee = DuréeApnée;
            this.ProfondeurPlongée = ProfondeurPlongée;
        }

        public void Afficher()
        {
            Console.WriteLine(" Nom: {0} \n LieuHabitation: {1} \n Cri: {2} \n Animal domestique : {3} \n Dangereux: {4} \n Durée sous l'eau: {5} \n Profondeur de plongée: {6}",nom,LieuHabitation,monCrie,jeSuisDomestique,JeSuisDangereux(),DuréeApnee,ProfondeurPlongée);
        }
    }
}
