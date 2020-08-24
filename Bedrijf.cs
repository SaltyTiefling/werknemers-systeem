using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace werknemers_systeem
{
    class Bedrijf
    {
        public string naam;
        public List<Werknemer> werknemerslijst = new List<Werknemer>();
        public string btwnummer;

        public Bedrijf(string naam, string btwnummer, List<Werknemer> werknemerslijst = null)
        {
            this.naam = naam;
            this.btwnummer = btwnummer;
            if (werknemerslijst != null) { this.werknemerslijst = werknemerslijst; }
        }
        public void AddWerknemer(params Werknemer[] werknemer)
        {
            foreach (var item in werknemer)
            {
                werknemerslijst.Add(item);
            }
        }
        public void VerwijderWerknemer(params Werknemer[] werknemer)
        {
            foreach (var item in werknemer)
            {
                werknemerslijst.Remove(item);
            }
        }

        public override string ToString()
        {
            return naam;
        }
    }
}
