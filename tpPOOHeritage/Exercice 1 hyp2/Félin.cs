using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpPOOHeritage
{
    class Félin:Mammifère
    {
        private int nombrePattes;
        

        public Félin(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, int nombrePattes):base(nom,LieuHabitation,monCrie,jeSuisDomestique)
        {
            
            this.nombrePattes = nombrePattes;
        }

        public int GetNombrepattes()
        {
            return nombrePattes;
        }

        
    }
}
