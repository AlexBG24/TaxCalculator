using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculator
{
    internal class TaxPayer
    {
        #region Data
        //Input Data
        private String Year { get; }
        private String Province { get; }
        private double GrossIncome { get; }
        private double CPPPaid { get; }
        private double EIPaid { get; }
        private double TaxPaid { get; }

        //Output Data
        public double IncomeTax { get; private set; }
        public double TaxesOwed
        {
            get
            {
                return IncomeTax - TaxPaid;
            }
        }
        public double MarginalTaxRate { get; private set; }
        public double EffectiveTaxRate
        {
            get
            {
                try
                {
                    return IncomeTax / GrossIncome;
                }
                catch (DivideByZeroException)
                {
                    return 0;
                }
            }
        }

        #endregion

        #region Constructor

        public TaxPayer(String Year, String Province, double GrossIncome, double CPPPaid, double EIPaid, double TaxPaid)
        {
            this.Year = Year;
            this.Province = Province;
            this.GrossIncome = GrossIncome;
            this.CPPPaid = CPPPaid;
            this.EIPaid = EIPaid;
            this.TaxPaid = TaxPaid;
        }
        #endregion

        #region Calculation

        public void CalculateTax()
        {
            this.IncomeTax = 100;
            this.MarginalTaxRate = 2;
        }

        #endregion
    }
}
