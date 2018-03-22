using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace concessionAutomobile
{
    public class Option
    {
        private string libellé;
        private double prix;

        public Option(string libellé, double prix)
        {
            this.libellé = libellé;
            this.prix = prix;
        }

        public double GetPrix() { return prix; }
        public string GetLibelle() { return libellé; }
        public new string ToString() { return String.Format("{0} {1}", this.libellé, this.prix); }
    }
}
