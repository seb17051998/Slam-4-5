using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace concessionAutomobile
{
    class Modèle
    {
        private List<Option> optionsModèle;
        string nom;
        double prix;

        public Modèle(string nom, double prix)
        {
            this.nom = nom;
            this.prix = prix;
            this.optionsModèle = new List<Option>();
        }

        public double GetPrix
        {
            get { return prix; }
        }

        

        public void AddOption(Option option)
        {
            optionsModèle.Add(option);
        }

        public Option this[int index]
        {
            get { return this.optionsModèle[index]; }
        }

        /*public bool PossèdeOption(string libellé)
        {
        }*/
        public int Count
        {
            get { return this.optionsModèle.Count; }
        }

        public new string ToString()
        {
            Console.Write("Modele : {0} {1} Euros\n", this.nom, this.GetPrix);
            for (int i = 0; i < optionsModèle.Count; i++)
            {
                Console.Write("{0} {1} Euros\n", optionsModèle[i].GetLibelle(), optionsModèle[i].GetPrix());
            }
            
            return string.Format("");
            
        }
    }
}
