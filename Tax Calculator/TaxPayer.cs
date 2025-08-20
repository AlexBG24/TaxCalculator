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

            this.IncomeTax = this.CalcFedTax() + this.CalcProvTax();
        }

        private decimal CalcFedTax()
        {
            decimal fedTax = 0;

            if (GrossIncome < TaxData.Years[this.Year].Federal.BasicPersonalAmount) { }
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

        private decimal CalcProvTax()
        {
            decimal provTax = 0;

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
