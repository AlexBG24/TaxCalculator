using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculator.Tests
{   
    [TestClass]
    public sealed class NumberManagerTests
    {
        [DataRow(0, "0.00")]
        [DataRow(1, "1.00")]
        [DataRow(1.05, "1.05")]
        [DataRow(1.004, "1.00")]
        [DataRow(1.005, "1.01")]
        [DataRow(1.055, "1.06")]
        [DataRow(2, "2.00")]
        [DataRow(2.0009, "2.00")]
        [DataRow(100, "100.00")]
        [DataRow(1000, "1,000.00")]
        [DataRow(10000, "10,000.00")]
        [DataRow(10000000, "10,000,000.00")]
        [TestMethod]
        public void OutputAsDollarValue(double value, string expected)
        {
            Assert.AreEqual(expected, NumberManager.OutputAsDollarValue((decimal)value));
        }

        [DataRow(0, "0.00")]
        [DataRow(0.00001, "0.00")]
        [DataRow(0.00005, "0.01")]
        [DataRow(0.0001, "0.01")]
        [DataRow(0.001, "0.10")]
        [DataRow(0.01, "1.00")]
        [DataRow(0.1, "10.00")]
        [DataRow(0.101, "10.10")]
        [DataRow(0.105, "10.50")]
        [DataRow(0.1005, "10.05")]
        [DataRow(0.10005, "10.01")]
        [DataRow(0.100005, "10.00")]
        [DataRow(0.5555, "55.55")]
        [DataRow(0.55555, "55.56")]
        [DataRow(0.9, "90.00")]
        [DataRow(1, "100.00")]
        [DataRow(2, "200.00")]
        [TestMethod]
        public void OutputAsPercentage(double value, string expected)
        {
            Assert.AreEqual(expected, NumberManager.OutputAsPercentage((decimal)value));
        }
    }
}
