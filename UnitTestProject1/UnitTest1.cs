using System;
using ejercicio06;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestConcatenar()
        {

            Metodo sut = new Metodo();

            String concatenacion = sut.Concatenar();
        }
    }
}
