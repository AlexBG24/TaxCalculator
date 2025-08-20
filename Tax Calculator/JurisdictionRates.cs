using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculator
{
    public class JurisdictionRates
    {
        public decimal BasicPersonalAmount { get; set; }
        public List<TaxBracket> Brackets { get; set; } = new();
    }
}
