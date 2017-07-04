using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejer03;

namespace TestEjer03
{
    [TestClass]
    public class UnitTest1
    {
        private Class1 sut; //convención: System Under Test
    
        [TestInitialize]  // Atributo para ejecutar antes de los métodos de test.
        public void TestInicial()
        {
            sut = new Class1();
        }

        [TestMethod] // Atributo (anotación Java) que indica que es un método de prueba, es la forma de que el código sepa que es tal, y no un código normal.
        public void TestResta()
        {
            int res = sut.Resta(5, 2);

            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void TestRestaNegativa()
        {
            int res = sut.Resta(-5,-2);

            Assert.AreEqual(-3, res);
        }
    }
}
