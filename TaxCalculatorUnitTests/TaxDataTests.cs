using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tax_Calculator.Tests
{   
    [TestClass]
    public sealed class TaxDataTests
    {
        [DataRow(0, 0)]
        [DataRow(100, 0.5)]
        [DataRow(2000, 5000)]
        [TestMethod]
        public void TaxBracket(double t, double r)
        {
            (decimal threshold, decimal rate) = ((decimal)t, (decimal)r);
            TaxBracket taxBracket = new TaxBracket{ Threshold = threshold, Rate = rate};

            Assert.AreEqual(threshold, taxBracket.Threshold);
            Assert.AreEqual(rate, taxBracket.Rate);
        }

        [DataRow(0, 0, 0, 0, 0)]
        [DataRow(100, 500, 0.2, 1000, 0.5)]
        [TestMethod]
        public void Jurisdiction(double bpa, double t1, double r1, double t2, double r2)
        {
            (decimal basicPersonalAmount, decimal threshold1, decimal rate1, decimal threshold2, decimal rate2) =
                                                ((decimal)bpa, (decimal)t1, (decimal)r1, (decimal)t2, (decimal)r2);

            JurisdictionRates jurisdiction = new JurisdictionRates
            {
                BasicPersonalAmount = basicPersonalAmount,
                Brackets = new List<TaxBracket>
                    {
                        new TaxBracket { Threshold = threshold1, Rate = rate1 },
                        new TaxBracket { Threshold = threshold2, Rate = rate2 },
                    }
            };

            Assert.AreEqual(basicPersonalAmount, jurisdiction.BasicPersonalAmount);
            Assert.AreEqual(threshold1, jurisdiction.Brackets[0].Threshold);
            Assert.AreEqual(rate1, jurisdiction.Brackets[0].Rate);
            Assert.AreEqual(threshold2, jurisdiction.Brackets[1].Threshold);
            Assert.AreEqual(rate2, jurisdiction.Brackets[1].Rate);
        }

        [DataRow(0, 0, 0, 0, 0, 0)]
        [DataRow(5000, 100, 500, 0.2, 1000, 0.5)]
        [TestMethod]
        public void TaxYear(int Year, double bpa, double ft, double fr, double pt, double pr)
        {
            (decimal basicPersonalAmount, decimal federalThreshold, decimal federalRate, decimal provincialThreshold, decimal provincialRate) =
                                    ((decimal)bpa, (decimal)ft, (decimal)fr, (decimal)pt, (decimal)pr);

            TaxYear year = new TaxYear
            {
                Year = Year,
                Federal = new JurisdictionRates
                {
                    BasicPersonalAmount = basicPersonalAmount,
                    Brackets = new List<TaxBracket>
                    {
                        new TaxBracket { Threshold = federalThreshold, Rate = federalRate },
                    }
                },

                Provincial = new Dictionary<string, JurisdictionRates>
                {
                    ["Province X"] = new JurisdictionRates
                    {
                        BasicPersonalAmount = basicPersonalAmount,
                        Brackets = new List<TaxBracket>
                        {
                            new TaxBracket { Threshold = provincialThreshold, Rate = provincialRate },
                        }
                    },
                }
            };

            Assert.AreEqual(basicPersonalAmount, year.Federal.BasicPersonalAmount);
            Assert.AreEqual(federalThreshold, year.Federal.Brackets[0].Threshold);
            Assert.AreEqual(federalRate, year.Federal.Brackets[0].Rate);
            Assert.AreEqual(provincialThreshold, year.Provincial["Province X"].Brackets[0].Threshold);
            Assert.AreEqual(provincialRate, year.Provincial["Province X"].Brackets[0].Rate);
        }
    }
}
