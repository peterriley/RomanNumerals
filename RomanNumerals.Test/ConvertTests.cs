using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;

namespace RomanNumerals.Test
{
    [TestClass]
    public class ConvertTests
    {
        [TestMethod]
        public void TestConvertToRoman_1000()
        {
            // Arrange
            int numberToConvert = 1000;
            var expected = "M";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_2000()
        {
            // Arrange
            int numberToConvert = 2000;
            var expected = "MM";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_2999()
        {
            // Arrange
            int numberToConvert = 2999;
            var expected = "MMCMXCIX";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_999()
        {
            // Arrange
            int numberToConvert = 999;
            var expected = "CMXCIX";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_547()
        {
            // Arrange
            int numberToConvert = 547;
            var expected = "DXLVII";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_1()
        {
            // Arrange
            int numberToConvert = 1;
            var expected = "I";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_3()
        {
            // Arrange
            int numberToConvert = 3;
            var expected = "III";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_4()
        {
            // Arrange
            int numberToConvert = 4;
            var expected = "IV";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_5()
        {
            // Arrange
            int numberToConvert = 5;
            var expected = "V";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_6()
        {
            // Arrange
            int numberToConvert = 6;
            var expected = "VI";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_8()
        {
            // Arrange
            int numberToConvert = 8;
            var expected = "VIII";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_9()
        {
            // Arrange
            int numberToConvert = 9;
            var expected = "IX";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_10()
        {
            // Arrange
            int numberToConvert = 10;
            var expected = "X";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_11()
        {
            // Arrange
            int numberToConvert = 11;
            var expected = "XI";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_13()
        {
            // Arrange
            int numberToConvert = 13;
            var expected = "XIII";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_14()
        {
            // Arrange
            int numberToConvert = 14;
            var expected = "XIV";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_15()
        {
            // Arrange
            int numberToConvert = 15;
            var expected = "XV";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_16()
        {
            // Arrange
            int numberToConvert = 16;
            var expected = "XVI";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_18()
        {
            // Arrange
            int numberToConvert = 18;
            var expected = "XVIII";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_19()
        {
            // Arrange
            int numberToConvert = 19;
            var expected = "XIX";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertToRoman_20()
        {
            // Arrange
            int numberToConvert = 20;
            var expected = "XX";

            // Act
            var actual = Convert.ConvertToRoman(numberToConvert, string.Empty);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertFromRoman_M()
        {
            // Arrange
            string numeralToConvert = "M";
            var expected = 1000;

            // Act
            var actual = Convert.ConvertFromRoman(numeralToConvert);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertFromRoman_MM()
        {
            // Arrange
            string numeralToConvert = "MM";
            var expected = 2000;

            // Act
            var actual = Convert.ConvertFromRoman(numeralToConvert);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertFromRoman_MMCMXCIX()
        {
            // Arrange
            string numeralToConvert = "MMCMXCIX";
            var expected = 2999;

            // Act
            var actual = Convert.ConvertFromRoman(numeralToConvert);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertFromRoman_CMXCIX()
        {
            // Arrange
            string numeralToConvert = "CMXCIX";
            var expected = 999;

            // Act
            var actual = Convert.ConvertFromRoman(numeralToConvert);

            // Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestConvertFromRoman_DXLVII()
        {
            // Arrange
            string numeralToConvert = "DXLVII";
            var expected = 547;

            // Act
            var actual = Convert.ConvertFromRoman(numeralToConvert);

            // Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
