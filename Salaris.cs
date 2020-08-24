using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace werknemers_systeem
{
    public class Salaris
    {
        contracttype contract { get; set; }
        public double bruttoBedrag = 0;
        public int percentage = 0;

        public Salaris(double bruttoBedrag = 2440.55, contracttype contract = contracttype.Maand, int percentage = 21)
        {
            this.contract = contract;
            this.bruttoBedrag = bruttoBedrag;
            this.percentage = percentage;
        }
        public enum contracttype { Week, Maand }


        public override string ToString()
        {
            return 
                $"Brutto: {bruttoBedrag}";
        }
    }
}
