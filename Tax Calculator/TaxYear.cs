using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculator
{
    public class TaxYear
    {
        public int Year { get; set; }

        public JurisdictionRates Federal { get; set; } = new();

        public Dictionary<string, JurisdictionRates> Provincial { get; set; } = new();

    }
}
