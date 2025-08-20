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
        private int Year { get; }
        private String Province { get; }
        private decimal GrossIncome { get; }
        private decimal CPPPaid { get; }
        private decimal EIPaid { get; }
        private decimal TaxPaid { get; }

        //Output Data
        public decimal IncomeTax { get; private set; }
        public decimal TaxesOwed
        {
            get
            {
                return IncomeTax - TaxPaid;
            }
        }
        public decimal MarginalTaxRate { get; private set; }
        public decimal EffectiveTaxRate
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

        public TaxPayer(String Year, String Province, decimal GrossIncome, decimal CPPPaid, decimal EIPaid, decimal TaxPaid)
        {
            this.Year = int.Parse(Year);
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
            this.IncomeTax = this.CalculateFederalTax() + this.CalculateProvincialTax();
        }

        private decimal CalculateFederalTax()
        {
            decimal FederalTax = 0;

            



            if (FederalTax < 0)
            {
                return 0;
            }
            else
            {
                return FederalTax;
            }
        }

        private decimal CalculateProvincialTax()
        {
            decimal ProvincialTax = 0;

            return ProvincialTax;
        }

        private static decimal CalculateCumulativeTax(JurisdictionRates Rates, int bracket) //Calculates taxes owed up to a certain bracket
        {
            decimal Taxes = 0;
            for (int i = 0; i < bracket; i++)
            {
                Taxes += Rates.Brackets[i].Rate * (Rates.Brackets[i + 1].Threshold - Rates.Brackets[i].Threshold);
            }

            return Taxes;
        }


        #endregion
    }
}
