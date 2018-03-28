using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpPOOHeritage
{
    class Félin:Mammifère
    {
        protected int nombrePattes;
        

        public Félin(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, int nombrePattes):base(nom,LieuHabitation,monCrie,jeSuisDomestique)
        {
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
            this.nombrePattes = nombrePattes;
        }

        public int GetNombrepattes()
        {
            return nombrePattes;
        }

        
    }
}
