using Xunit;
using System.Numerics;
using MyOwnLib;

namespace MyOwnLibTest;
    public class OwnTests
    {
        [Fact]
        public void MyPow_TwoIntegers_ReturnsCorrectResult()
        {
            // Arrange
            var own = new Own();
            int baseNumber = 2;
            int exponent = 3;
            BigInteger expected = BigInteger.Pow(baseNumber, exponent);

            // Act
            BigInteger actual = own.MyPow(baseNumber, exponent);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyPow_ParamsArray_ReturnsCorrectResult()
        {
            // Arrange
            var own = new Own();
            int[] numbers = { 2, 3, 2 };
            BigInteger expected = 64; // 2^3 * 2^2 = 64

            // Act
            BigInteger actual = own.MyPow(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MyPow_NullParamsArray_ThrowsArgumentException()
        {
            // Arrange
            var own = new Own();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => own.MyPow(null));
        }

        [Fact]
        public void MyPow_EmptyParamsArray_ThrowsArgumentException()
        {
            // Arrange
            var own = new Own();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => own.MyPow());
        }
    }