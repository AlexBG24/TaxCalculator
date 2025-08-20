using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private JurisdictionRates Federal { get; }
        private JurisdictionRates Provincial { get; }

        //Output Data
        public decimal IncomeTax { get; private set; }
        public decimal TaxesOwed
        {
            get
            {
                return IncomeTax - TaxPaid;
            }
        }
        public decimal MarginalTaxRate
        {
            get
            {
                return Federal.Brackets[GetMarginalTaxBracket(this.GrossIncome, this.Federal.Brackets)].Rate;
            }
        }
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

            this.Federal = TaxData.Years[this.Year].Federal;
            this.Provincial = TaxData.Years[this.Year].Provincial[Province];
        }
        #endregion

        #region Calculation

        public void CalculateTax()
        {
            decimal FederalTax = CalculateJurisdictionTax(Federal);
            decimal ProvincialTax = CalculateJurisdictionTax(Provincial);

            decimal FederalTaxCredits = CalculateTaxCredits(Federal.Brackets[0].Rate, Federal.BasicPersonalAmount);
            decimal ProvincialTaxCredits = CalculateTaxCredits(Provincial.Brackets[0].Rate, Provincial.BasicPersonalAmount);

            FederalTax -= FederalTaxCredits;
            ProvincialTax -= ProvincialTaxCredits;

            this.IncomeTax = (FederalTax > 0 ? FederalTax : 0) + (ProvincialTax > 0 ? ProvincialTax : 0);
        }

        private decimal CalculateJurisdictionTax(JurisdictionRates jurisdiction)
        {
            decimal Tax = 0;

            Tax += CalculateCumulativeTax(jurisdiction.Brackets, this.GrossIncome);
            Tax += CalculateMarginalTax(jurisdiction.Brackets, this.GrossIncome);

            return Tax;
        }

        private static decimal CalculateCumulativeTax(List<TaxBracket> Brackets, decimal GrossIncome) //Calculates taxes owed up to a certain bracket
        {
            int MarginalTaxBracket = GetMarginalTaxBracket(GrossIncome, Brackets);

            decimal Taxes = 0;
            for (int i = 0; i < MarginalTaxBracket; i++)
            {
                Taxes += Brackets[i].Rate * (Brackets[i + 1].Threshold - Brackets[i].Threshold);
            }

            return Taxes;
        }

        private static decimal CalculateMarginalTax(List<TaxBracket> Brackets, decimal GrossIncome)
        {
            int MarginalTaxBracket = GetMarginalTaxBracket(GrossIncome, Brackets);
            return Brackets[MarginalTaxBracket].Rate * (GrossIncome - Brackets[MarginalTaxBracket].Threshold);
        }

        private static int GetMarginalTaxBracket(decimal GrossIncome, List<TaxBracket> Brackets)
        {
            int i = 0;

            while (Brackets[i+1].Threshold < GrossIncome)
            {
                i++;
            }

            return i;
        }

        private static decimal CalculateTaxCredits(decimal TaxCreditRate, params decimal[] Credits)
        {
            decimal TotalCredits = 0;
            for (int i = 0; i < Credits.Length; i++)
            {
                TotalCredits += Credits[i];
            }
            return TotalCredits*TaxCreditRate;
        }
        #endregion
    }
}
