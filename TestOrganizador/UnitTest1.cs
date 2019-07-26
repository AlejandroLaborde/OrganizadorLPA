using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsultasDB;
using System.Collections.Generic;
using Entidades;

namespace TestOrganizador
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_obtieneMonedas()
        {
            List<Moneda> monedas = SqlServer.obtieneMonedas();
            Assert.IsTrue(monedas.Count != 0);
        }
    }
}
