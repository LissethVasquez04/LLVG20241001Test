using Microsoft.VisualStudio.TestTools.UnitTesting;
using LLVG20241001Test;

namespace LLVG20241001Test.Tests
{
    [TestClass]
    public class CalculadoraTests
    {
        private Calculadora calculadora;

        [TestInitialize]
        public void Setup()
        {
            calculadora = new Calculadora();
        }

        [TestMethod]
        public void CalcularRaizCuadrada_Cero_RetornaCero()
        {
            // Act
            var resultado = calculadora.CalcularRaizCuadrada(0);
            // Assert
            Assert.AreEqual(0, resultado);
        }
        [TestMethod]
        public void CalcularRaizCuadrada_AceptaNumeroDouble()
        {
            // Act
            var resultado = calculadora.CalcularRaizCuadrada(4.0);
            // Assert
            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        public void CalcularRaizCuadrada_Negativo_LanzaExcepcion()
        {
            // Act & Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => calculadora.CalcularRaizCuadrada(-4));
        }

        [TestMethod]
        public void CalcularRaizCuadrada_NumeroPositivo_RetornaRaizCorrecta()
        {
            // Act
            var resultado = calculadora.CalcularRaizCuadrada(9);
            // Assert
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void CalcularRaizCuadrada_NumeroDecimal_RetornaRaizCorrecta()
        {
            // Act
            var resultado = calculadora.CalcularRaizCuadrada(2.25);
            // Assert
            Assert.AreEqual(1.5, resultado, 0.0001); // Con tolerancia
        }
    }
}

