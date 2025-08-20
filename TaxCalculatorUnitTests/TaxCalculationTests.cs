using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tax_Calculator;

namespace Tax_Calculator.Tests
{
    [TestClass]
    public sealed class TaxCalculationTests
    {

        [DataRow("2024", "Ontario", 1000, 10, 10, 10)] //Inputs are limited to positive numbers, selecatble years and provinces
        [DataRow("2004", "British Columbia", 1000, 0, 0, 0)]
        [TestMethod]
        public void TaxPayerConstructor(string Year, string Province, double GrossIncome, double CPPPaid, double EIPaid, double TaxPaid)
        {
            TaxPayer taxPayer = new TaxPayer(Year, Province, (decimal)GrossIncome, (decimal)CPPPaid, (decimal)EIPaid, (decimal)TaxPaid);

            Assert.IsNotNull(taxPayer);
        }

        [DataRow("2024", "Ontario", 0, 1)]
        [DataRow("2024", "Ontario", 1000, 1)]
        [DataRow("2024", "Ontario", 50000, 2)]
        [DataRow("2024", "Ontario", 100000, 3)]
        [DataRow("2024", "Ontario", 150000, 4)]
        [DataRow("2024", "Ontario", 250000, 5)]
        [TestMethod]
        public void MarginalTaxBracket(string Year, string Province, double GrossIncome, int ExpectedTaxBracket) 
        {
            JurisdictionRates jurisdiction = TaxData.Years[int.Parse(Year)].Federal;
            int ActualTaxBracket = TaxPayer.GetMarginalTaxBracket((decimal)GrossIncome, jurisdiction.Brackets);

            Assert.AreEqual(ExpectedTaxBracket, ActualTaxBracket);
        }
    }
}
