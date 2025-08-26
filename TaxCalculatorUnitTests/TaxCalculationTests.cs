using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using Tax_Calculator;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tax_Calculator.Tests
{
    [TestClass]
    public sealed class TaxCalculationTests
    {
        private readonly decimal RateTolerance = 1e-6m;
        private readonly decimal NumberTolerance = 1e-9m;

        //Test jurisdiction: A set of simple tax brackets with easy values to test

        private readonly JurisdictionRates testJurisdiction = new()
        {
            BasicPersonalAmount = 1000m,
            Brackets = new List<TaxBracket>
                    {
                        new TaxBracket { Threshold = 0m, Rate = 0.1m },
                        new TaxBracket { Threshold = 2000m, Rate = 0.2m},
                        new TaxBracket { Threshold = 5000m, Rate = 0.5m},
                        new TaxBracket { Threshold = 8000m, Rate = 0.8m},
                    }
        };



        [DataRow("2024", "Ontario", 1000, 10, 10, 10)] //Inputs are limited to positive numbers, selecatble years and provinces
        [DataRow("2024", "Quebec", 1000, 0, 0, 0)]
        [TestMethod]
        public void TaxPayerConstructor(string Year, string Province, double GI, double CPPP, double EIP, double TP)
        {
            (decimal GrossIncome, decimal CPPPaid, decimal EIPaid, decimal TaxPaid) = ((decimal)GI, (decimal)CPPP, (decimal)EIP, (decimal)TP);

            TaxPayer taxPayer = new TaxPayer(Year, Province, GrossIncome, CPPPaid, EIPaid, TaxPaid);

            Assert.IsNotNull(taxPayer);
        }

        [DataRow("2024", 0, 0)]
        [DataRow("2024", 1000, 0)]
        [DataRow("2024", 53359, 0)]
        [DataRow("2024", 55000, 1)]
        [DataRow("2024", 106717, 1)]
        [DataRow("2024", 110000, 2)]
        [DataRow("2024", 165430, 2)]
        [DataRow("2024", 200000, 3)]
        [DataRow("2024", 235675, 3)]
        [DataRow("2024", 250000, 4)]
        [TestMethod]
        public void MarginalTaxBracket(string Year, double GrossIncome, int ExpectedTaxBracket) 
        {
            JurisdictionRates jurisdiction = TaxData.Years[int.Parse(Year)].Federal;
            int ActualTaxBracket = TaxPayer.GetMarginalTaxBracket((decimal)GrossIncome, jurisdiction.Brackets);

            Assert.AreEqual(ExpectedTaxBracket, ActualTaxBracket);
        }

        [DataRow("2024", "Ontario", 0, 0.15, 0.0505)]
        [DataRow("2024", "Ontario", 1000, 0.15, 0.0505)]
        [DataRow("2024", "Ontario", 49231, 0.15, 0.0505)]
        [DataRow("2024", "Ontario", 50000, 0.15, 0.0915)]
        [DataRow("2024", "Ontario", 53359, 0.15, 0.0915)]
        [DataRow("2024", "Ontario", 65000, 0.205, 0.0915)]
        [DataRow("2024", "Ontario", 98463, 0.205, 0.0915)]
        [DataRow("2024", "Ontario", 100000, 0.205, 0.1116)]
        [DataRow("2024", "Ontario", 106717, 0.205, 0.1116)]
        [DataRow("2024", "Ontario", 125000, 0.26, 0.1116)]
        [DataRow("2024", "Ontario", 150000, 0.26, 0.1116)]
        [DataRow("2024", "Ontario", 160000, 0.26, 0.1216)]
        [DataRow("2024", "Ontario", 165430, 0.26, 0.1216)]
        [DataRow("2024", "Ontario", 200000, 0.29, 0.1216)]
        [DataRow("2024", "Ontario", 220000, 0.29, 0.1216)]
        [DataRow("2024", "Ontario", 235675, 0.29, 0.1316)]
        [DataRow("2024", "Ontario", 250000, 0.33, 0.1316)]
        [TestMethod]
        public void MarginalTaxRate(string Year, string Province, double GrossIncome, double ExpectedFederalTaxRate, double ExpectedProvincialTaxRate)
        {
            JurisdictionRates jurisdiction = TaxData.Years[int.Parse(Year)].Federal;
            int ActualTaxBracket = TaxPayer.GetMarginalTaxBracket((decimal)GrossIncome, jurisdiction.Brackets);

            TaxPayer taxPayer = new TaxPayer(Year, Province, (decimal)GrossIncome, 0, 0, 0);

            Assert.AreEqual((decimal)ExpectedFederalTaxRate, taxPayer.FederalMarginalTaxRate);
            Assert.AreEqual((decimal)ExpectedProvincialTaxRate, taxPayer.ProvincialMarginalTaxRate);
        }

        [DataRow(0, 0)]
        [DataRow(1000, 0)]
        [DataRow(2000, 0)]
        [DataRow(3000, 200)]
        [DataRow(5000, 200)]
        [DataRow(6000, 200 + 600)]
        [DataRow(8000, 200 + 600)]
        [DataRow(9000, 200 + 600 + 1500)]
        [DataRow(10000000, 200 + 600 + 1500)]
        [TestMethod]
        public void CumulativeTax(double GI, double ECT)
        {
            (decimal GrossIncome, decimal ExpectedCumulativeTax) = ((decimal)GI, (decimal)ECT);

            decimal ActualCumulativeTax = TaxPayer.CalculateCumulativeTax(testJurisdiction.Brackets, GrossIncome);

            Assert.AreEqual(ExpectedCumulativeTax, ActualCumulativeTax);
        }

        /*      new TaxBracket { Threshold = 0m, Rate = 0.1m },
                new TaxBracket { Threshold = 2000m, Rate = 0.2m},
                new TaxBracket { Threshold = 5000m, Rate = 0.5m },
                new TaxBracket { Threshold = 8000m, Rate = 0.8m }, */

        [DataRow(0, 0)]
        [DataRow(1000, 100)]
        [DataRow(1500, 150)]
        [DataRow(2000, 200)]
        [DataRow(3000, 200)]
        [DataRow(4000, 400)]
        [DataRow(5000, 600)]
        [DataRow(6000, 500)]
        [DataRow(8000, 1500)]
        [DataRow(10000, 1600)]
        [TestMethod]
        public void MarginalTax(double GI, double EMT)
        {
            (decimal GrossIncome, decimal ExpectedMarginalTax) = ((decimal)GI, (decimal)EMT);

            decimal ActualMarginalTax = TaxPayer.CalculateMarginalTax(testJurisdiction.Brackets, GrossIncome);

            Assert.AreEqual(ExpectedMarginalTax, ActualMarginalTax);
        }

        [DataRow("2024", "Ontario", 0, 0, 0, 0, 0)]
        [DataRow("2024", "Ontario", 1000, 0, 0, 0, 0)]
        [DataRow("2024", "Ontario", 12071, 0, 0, 0, 0)]
        [DataRow("2024", "Ontario", 15000, 0, 0, 0, 0.00986096666667)]
        [TestMethod]
        public void EffectiveTaxRate(string Year, string Province, double GI, double CPPP, double EIP, double TP, double ETR)
        {
            (decimal GrossIncome, decimal CPPPaid, decimal EIPaid, decimal TaxPaid, decimal ExpectedTaxRate) 
                = ((decimal)GI, (decimal)CPPP, (decimal)EIP, (decimal)TP, (decimal)ETR );

            TaxPayer taxPayer = new TaxPayer(Year, Province, GrossIncome, CPPPaid, EIPaid, TaxPaid);

            taxPayer.CalculateTax();

            Assert.AreEqual(ExpectedTaxRate, taxPayer.EffectiveTaxRate, RateTolerance);
        }

        [DataRow(0, 0, 0)]
        [DataRow(0, 0.1, 0)]
        [DataRow(30, 0.1, 100, 100, 100)]
        [DataRow(550, 0.5, 100, 200, 800)]
        [DataRow(50550, 0.5, 100, 200, 800, 100000)]
        [DataRow(20, 2, 10)]
        [TestMethod]
        public void TaxCredits(double EC, double R, params double[] C)
        {
            decimal ExpectedCredits = (decimal)EC;
            decimal Rate = (decimal)R;
            decimal[] Credits = C.Select(d => (decimal)d).ToArray();

            decimal ExpectedTotalCredits = Credits.Sum();

            decimal ActualTotalCredits = TaxPayer.CalculateTaxCredits(Rate, Credits);

            Assert.AreEqual(ExpectedCredits, ActualTotalCredits, NumberTolerance);
        }
    }
}
