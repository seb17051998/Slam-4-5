using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpPOOHeritage
{
    class Mammifère:Object
    {
        protected string nom;
        protected string LieuHabitation;
        protected string monCrie;
        protected bool jeSuisDomestique;
        protected string espece;
        Félin lesFélins;
        

        public Mammifère(string nom, string LieuHabitation, string monCrie, bool jeSuisDomestique)
        {
            
            this.nom = nom;
            this.LieuHabitation = LieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;

        }
        
        public bool JeSuisDangereux()
        {
            return true;
           
        }

        public string ToString()
        {
            return string.Format(" Nom: {0}\n, LieuHabitation: {1}\n, monCrie: {2}\n, Animal domestique: {3}\n, Dangereux :{4}", nom, LieuHabitation, monCrie, jeSuisDomestique, JeSuisDangereux());
        }
    }
}
