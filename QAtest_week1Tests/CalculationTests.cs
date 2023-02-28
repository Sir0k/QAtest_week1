using Microsoft.VisualStudio.TestTools.UnitTesting;
using QAtest_week1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace QAtest_week1.Tests
{
    [TestClass()]
    public class CalculationTests
    {

        // Простые тесты

        [TestMethod]
        public void ReturnsCorrectResult_WhenUsingProductType1AndMaterialType1()
        {
            
            var productType = 1;
            var materialType = 1;
            var count = 10;
            var width = 20;
            var length = 30;
            var expected = 6620;

            
            var result = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnsCorrectResult_WhenUsingProductType2AndMaterialType2()
        {
            
            var productType = 2;
            var materialType = 2;
            var count = 5;
            var width = 10;
            var length = 40;
            var expected = 5007;

            
            var result = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnsCorrectResult_WhenUsingProductType3AndMaterialType1()
        {
            
            var productType = 3;
            var materialType = 1;
            var count = 15;
            var width = 20;
            var length = 45;
            var expected = 114148;

            
            var result = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnsCorrectResult_WhenUsingProductType1AndMaterialType2()
        {
            
            var productType = 1;
            var materialType = 2;
            var count = 8;
            var width = 50;
            var length = 60;
            var expected = 26432;

            
            var result = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnsNegativeOne_WhenUsingInvalidProductType()
        {
            
            var productType = 4;
            var materialType = 1;
            var count = 10;
            var width = 20;
            var length = 30;
            var expected = -1;

            
            var result = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

            
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnsNegativeOne_WhenUsingInvalidMaterialType()
        {
            
            var productType = 1;
            var materialType = 3;
            var count = 10;
            var width = 20;
            var length = 30;
            var expected = -1;

            
            var result = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);

            
            Assert.AreEqual(expected, result);
        }

        

        // Сложные тесты

        [TestMethod]
        public void ReturnsCorrectResult_WhenUsingIntMaxValue()
        {

            var productType = 2;
            var materialType = 1;
            var count = int.MaxValue;
            var width = 1;
            var length = 1;
            var expected = "mnogo";


            var result = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnsNegativeOne_WhenUsingIntMinValue()
        {
            
            var productType = 2;
            var materialType = 1;
            var count = int.MinValue;
            var width = 1;
            var length = 1;
            var expected = -1;
            

            var result = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnsNegativeOne_WhenUsingProductType0AndMaterialtype0()
        {

            var productType = 0;
            var materialType = 0;
            var count = 10;
            var width = 20;
            var length = 30;
            var expected = -1;


            var result = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnsNegativeOne_WhenUsingNegativeCountAndLength()
        {

            var productType = 1;
            var materialType = 2;
            var count = -10;
            var width = 20;
            var length = -30;
            var expected = -1;


            var result = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);


            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ReturnsNegativeOne_WhenUsingZeroValues()
        {

            var productType = 1;
            var materialType = 2;
            var count = 0;
            var width = 0;
            var length = 0;
            var expected = -1;


            var result = Calculation.GetQuantityForProduct(count, width, length, productType, materialType);


            Assert.AreEqual(expected, result);
        }

    }
}