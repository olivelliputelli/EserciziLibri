using System;
using Xunit;
using EserciziCicloWhileDoWhile;


namespace XUnitTestProject
{
    public class ProdottoTest
    {
        [Fact]
        public void Prodotto_VaolriSempliciNegativiShouldCalculate()
        {
            // Arrange
            int expected = 12;

            // Act
            int actual = Program.ProdottoDo(-4, -3);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Prodotto_VaolriSempliciNegativoShouldCalculate()
        {
            // Arrange
            int expected = -15;

            // Act
            int actual = Program.ProdottoDo(5, -3);

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Prodotto_VaolriSempliciZeroShouldCalculate()
        {
            // Arrange
            int expected = 0;

            // Act
            int actual = Program.ProdottoDo(5, 0);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
