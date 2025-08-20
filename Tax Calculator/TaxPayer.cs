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

            this.IncomeTax = this.CalcFedTax() + this.CalcProvTax();
        }

        private double CalcFedTax()
        {
            double fedTax = 0;

            if (GrossIncome < TaxRates.Canada[Year].BasicPersonalAmount) { }
            else
            {
                for (int i = 0; i < TaxRates.Canada[Year].Bracket.Length; i++)
                {
                    if (GrossIncome < TaxRates.Canada[Year].Bracket[i])
                    {
                        fedTax += TaxRates.Canada[Year].Rates[i] * (GrossIncome - TaxRates.Canada[Year].Brackets[i]);
                    }
                }
            }
            return fedTax;
        }

        private double CalcProvTax()
        {
            double provTax = 0;

            if (GrossIncome < TaxRates.Province[Year].BasicPersonalAmount) { }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    if (GrossIncome < TaxRates.Province[Year].Bracket[i])
                    {
                        provTax += TaxRates.Province[Year].Rates[i] * (GrossIncome - TaxRates.Province[Year].Brackets[i]);
                    }
                }
            }
            return provTax;
        }

        #endregion
    }
}
