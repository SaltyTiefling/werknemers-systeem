using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace werknemers_systeem
{
    public class Werknemer
    {
        public string naam;
        public Salaris salaris = new Salaris();
        public string moederland;

        public Werknemer(string naam, Salaris salaris = null, string moederland = "België")
        {
            this.naam = naam;
            if (salaris != null) this.salaris = salaris;
            this.moederland = moederland;
        }

        public override string ToString()
        {
            return naam;
        }
    }
}
