using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpPOOHeritage
{
    class Cétacé:Mammifère
    {
        protected int DuréeApnee;
        protected int ProfondeurPlongée;
        

        public Cétacé(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, int DuréeApnée, int ProfondeurPlongée):base(nom, LieuHabitation, monCrie, jeSuisDomestique)
        {
            this.nom = nom;
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
            this.DuréeApnee = DuréeApnée;
            this.ProfondeurPlongée = ProfondeurPlongée;
        }
    }
}
