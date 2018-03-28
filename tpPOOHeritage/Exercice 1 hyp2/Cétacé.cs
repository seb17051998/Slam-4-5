using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpPOOHeritage
{
    class Cétacé:Mammifère
    {
        private int DuréeApnee;
        private int ProfondeurPlongée;
        

        public Cétacé(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique, int DuréeApnée, int ProfondeurPlongée):base(nom, LieuHabitation, monCrie, jeSuisDomestique)
        {
            
            this.DuréeApnee = DuréeApnée;
            this.ProfondeurPlongée = ProfondeurPlongée;
        }

        public int GetDuréeApnée()
        {
            return DuréeApnee;
        }

        public int GetProfondeur()
        {
            return ProfondeurPlongée;
        }
    }
}
