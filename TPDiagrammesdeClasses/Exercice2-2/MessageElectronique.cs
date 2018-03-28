using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercice2_2
{
    class MessageElectronique
    {
        public string adresseDestinataire;
        public string titre;
        public Corps leCorps;
        public En_tête entete;

        public MessageElectronique(string adresseDestinataire, string titre)
        {
            leCorps = new Corps();
            entete = new En_tête();
            this.adresseDestinataire = adresseDestinataire;
            this.titre = titre;
        }
    }
}
