using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tpPOOHeritage
{
    class Mammifère:Object
    {
        private string nom;
        private string LieuHabitation;
        private string monCrie;
        private bool jeSuisDomestique;
        private string espece;
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

        public string GetNom()
        {
            return this.nom;
        }

        public string GetLieuHabitation()
        {
            return this.LieuHabitation;
        }

        public string GetMonCrie()
        {
            return this.monCrie;
        }

        public bool GetJeSuisDomestique()
        {
            return this.jeSuisDomestique;
        }

        public string ToString()
        {
            return string.Format(" Nom: {0}\n, LieuHabitation: {1}\n, monCrie: {2}\n, Animal domestique: {3}\n, Dangereux :{4}", nom, LieuHabitation, monCrie, jeSuisDomestique, JeSuisDangereux());
        }
    }
}
