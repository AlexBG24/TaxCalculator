using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculator
{
    public static class TaxData
    {
        public static readonly Dictionary<int, TaxYear> Years = new Dictionary<int, TaxYear>
        {
            #region 2024
            [2024] = new TaxYear
            {
                Year = 2024,
                Federal = new JurisdictionRates
                {
                    BasicPersonalAmount = 15000m,
                    Brackets = new List<TaxBracket>
                    {
                        new TaxBracket { Threshold = 0, Rate = 0.15m },
                        new TaxBracket { Threshold = 53359, Rate = 0.205m },
                        new TaxBracket { Threshold = 106717, Rate = 0.26m },
                        new TaxBracket { Threshold = 165430, Rate = 0.29m },
                        new TaxBracket { Threshold = 235675, Rate = 0.33m }
                    }
                },
                Provincial = new Dictionary<string, JurisdictionRates>
                {
                    ["British Columbia"] = new JurisdictionRates
                    {
                        BasicPersonalAmount = 0,
                        Brackets = new List<TaxBracket>
                        {
                        }
                    },
                    ["Alberta"] = new JurisdictionRates
                    {
                        BasicPersonalAmount = 0,
                        Brackets = new List<TaxBracket>
                        {
                        }
                    },
                    ["Saskatchewan"] = new JurisdictionRates
                    {
                        BasicPersonalAmount = 0,
                        Brackets = new List<TaxBracket>
                        {
                        }
                    },
                    ["Manitoba"] = new JurisdictionRates
                    {
                        BasicPersonalAmount = 0,
                        Brackets = new List<TaxBracket>
                        {
                        }
                    },
                    ["Ontario"] = new JurisdictionRates
                    {
                        BasicPersonalAmount = 12071m,
                        Brackets = new List<TaxBracket>
                        {
                            new TaxBracket { Threshold = 0, Rate = 0.0505m },
                            new TaxBracket { Threshold = 49231, Rate = 0.0915m },
                            new TaxBracket { Threshold = 98463, Rate = 0.1116m },
                            new TaxBracket { Threshold = 150000, Rate = 0.1216m },
                            new TaxBracket { Threshold = 220000, Rate = 0.1316m }
                        }
                    },
                    ["Quebec"] = new JurisdictionRates
                    {
                        BasicPersonalAmount = 17283m,
                        Brackets = new List<TaxBracket>
                        {
                            new TaxBracket { Threshold = 0, Rate = 0.15m },
                            new TaxBracket { Threshold = 49275, Rate = 0.20m },
                            new TaxBracket { Threshold = 98540, Rate = 0.24m },
                            new TaxBracket { Threshold = 119910, Rate = 0.2575m }
                        }
                    },
                    ["New Brunswick"] = new JurisdictionRates
                    {
                        BasicPersonalAmount = 0,
                        Brackets = new List<TaxBracket>
                        {
                        }
                    },
                    ["Nova Scotia"] = new JurisdictionRates
                    {
                        BasicPersonalAmount = 0,
                        Brackets = new List<TaxBracket>
                        {
                        }
                    },
                    ["Prince Edward Island"] = new JurisdictionRates
                    {
                        BasicPersonalAmount = 0,
                        Brackets = new List<TaxBracket>
                        {
                        }
                    },
                    ["Newfoundland and Labrador"] = new JurisdictionRates
                    {
                        BasicPersonalAmount = 0,
                        Brackets = new List<TaxBracket>
                        {
                        }
                    },
                }
            }
        #endregion
        };
    }
}
