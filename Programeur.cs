using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace werknemers_systeem
{
    public class Programeur : Werknemer
    {
        List<string> programeertalen = new List<string>();
        public Programeur(string naam, Salaris salaris = null, string moederland = "België", params string[] programeertalen) 
            : base(naam,salaris,moederland)
        {
            this.programeertalen.Add("HTML");
            this.programeertalen.Add("Java SE 11");

            foreach (string item in programeertalen)
            {
                this.programeertalen.Add(item);
            }
        }

        public override double BerekenNetto()
        {
            return base.BerekenNetto();
        }

        public string PrintoutProgrameertalen()
        {
            string result = "";
            foreach (string item in programeertalen)
            {
                result += $"{item}; ";
            }

            return result;
        }

        public override string ToString()
        {
            return base.ToString() + " (Programeur)";
        }
    }
}
