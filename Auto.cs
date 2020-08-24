using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace werknemers_systeem
{
    class Auto
    {
        double belastbareLoon { get; set; }
        double nettoVergoeding { get; set; }

        public Auto(double belastbareLoon = 123, double nettoVergoeding = 50)
        {
            this.belastbareLoon = belastbareLoon;
            this.nettoVergoeding = nettoVergoeding;
        }
    }
}
