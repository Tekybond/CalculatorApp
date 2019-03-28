using CalculatorApp.BAL;
using CalculatorApp.BAL.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorApp.Tests.BAL
{
    [TestClass]
    public class OhmValueCalculatorTest
    {
        private readonly IOhmValueCalculator ObjOhmValueCalculator;
        public OhmValueCalculatorTest()
        {

            ObjOhmValueCalculator = new OhmValueCalculator();
        }

        [TestMethod]
        public void MinLimitTest()
        {
            var result = ObjOhmValueCalculator.CalculateOhmValue("BK", "BK", "BK", "BK");
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void MaxLimitTest()
        {
            var result = ObjOhmValueCalculator.CalculateOhmValue("WH", "WH", "WH", "WH");

            Assert.AreEqual(99000000000, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Validation failed: No Exception Thrown")]
        public void InvalidBandATest()
        {
            ObjOhmValueCalculator.CalculateOhmValue("", "WH", "BK", "BK");
        }

        [TestMethod]
        public void InvalidBandAMessageTest()
        {
            try
            {
                var val = ObjOhmValueCalculator.CalculateOhmValue("12", "WH", "WH", "WH");
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Invalid Band A color");
                return;
            }
            Assert.Fail("No Exception Thrown");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Validation failed: No Exception Thrown")]
        public void InvalidBandBTest()
        {
            var val = ObjOhmValueCalculator.CalculateOhmValue("WH", "", "WH", "WH");
        }

        [TestMethod]
        public void InvalidBandBMessageTest()
        {
            try
            {
                var val = ObjOhmValueCalculator.CalculateOhmValue("WH", "12", "WH", "WH");
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Invalid Band B color");
                return;
            }

            Assert.Fail("No Exception Thrown");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Validation failed: No Exception Thrown")]
        public void InvalidBandCTest()
        {
            ObjOhmValueCalculator.CalculateOhmValue("WH", "WH", "", "WH");
        }

        [TestMethod]
        public void InvalidBandCMessageTest()
        {
            try
            {
                var val = ObjOhmValueCalculator.CalculateOhmValue("WH", "WH", "123", "WH");
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Invalid Band C color");
                return;
            }

            Assert.Fail("No Exception Thrown");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "Validation failed: No Exception Thrown")]
        public void InvalidBandDTest()
        {
            ObjOhmValueCalculator.CalculateOhmValue("WH", "WH", "WH", "");
        }

        [TestMethod]
        public void InvalidBandDMessageTest()
        {
            try
            {
                var val = ObjOhmValueCalculator.CalculateOhmValue("WH", "WH", "WH", "123");
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "Invalid Band D color");
                return;
            }

            Assert.Fail("No Exception Thrown");
        }

        [TestMethod]
        public void GetRingColorModelTest()
        {
            var result = ObjOhmValueCalculator.GetRingColorModel();
            Assert.IsNotNull(result);
        }
    }
}
