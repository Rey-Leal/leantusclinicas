using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeantusClinicas
{
    /// <summary>
    /// Summary description for TstPessoas
    /// </summary>
    [TestClass]
    public class TstPessoas
    {
        public TstPessoas()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void Construtor()
        {
            LeantusClinicas.BoPessoas pessoa = new BoPessoas(1, "Reinaldo Leal", "MG-12345678", "1234567890", "Juventino Dias", "Santa Terezinha", "", "Itaú de Minas", "MG", "37975-000", "(035)3536-3536", "(035)9808-3794", "reinaldoleal2@gmail.com", "Analista de Sistemas", "", "solteiro", "Yoshi", "28/05/1985 00:00:00", "07/03/2010 12:32:11", "1141", "rey", "123");
            Assert.IsTrue((pessoa.Nivel == 1) && (pessoa.Nome == "Reinaldo Leal") && (pessoa.Rg == "MG-12345678") && (pessoa.Cpf == "1234567890") && (pessoa.Rua == "Juventino Dias"));
        }
        [TestMethod()]
        public void ErroConstrutor()
        {
            LeantusClinicas.BoPessoas pessoa = new BoPessoas(1, "Reinaldo Leal", "MG-12345678", "1234567890", "Juventino Dias", "Santa Terezinha", "", "Itaú de Minas", "MG", "37975-000", "(035)3536-3536", "(035)9808-3794", "reinaldoleal2@gmail.com", "Analista de Sistemas", "", "solteiro", "Yoshi", "28/05/1985 00:00:00", "07/03/2010 12:32:11", "1141", "rey", "123");
            Assert.IsFalse((pessoa.Nivel != 1) && (pessoa.Nome != "Reinaldo Leal") && (pessoa.Rg != "MG-12345678") && (pessoa.Cpf != "1234567890") && (pessoa.Rua != "Juventino Dias"));
        }
    }
}
