using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace concessionAutomobile
{
    class Vehicule
    {
        private List<Option> optionsBase;
        private string immatriculation;
        public Vehicule(string immatriculation)
        {
            this.immatriculation = immatriculation;
            this.optionsBase = new List<Option>();
        }

        public void AddOption(Option option)
        {
            optionsBase.Add(option);
        }

        public bool possèdeOption(string libelle)
        {
            bool option = true;
            return option;
        }

        public Option this[int index]
        {
            get { return this.optionsBase[index]; }
        }

        public int count { get { return this.optionsBase.Count; } }
        
        public new string ToString()
        {
            Console.WriteLine("Véhicule : {0}", this.immatriculation);
            for (int i = 0; i < optionsBase.Count; i++)
            {
                Console.Write("{0} {1} Euros\n", optionsBase[i].GetLibelle(), optionsBase[i].GetPrix());
            }
            //Console.WriteLine();
            return string.Format("");
        }
    }
}
