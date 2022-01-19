using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using WinFormTest;

namespace UnitTestProject1
{
    /// <summary>
    /// Descrizione del riepilogo per TestWinF
    /// </summary>
    [TestClass]
    public class TestWinF
    {
        public TestWinF()
        {
            //
            // TODO: aggiungere qui la logica del costruttore
            //

        }

        private TestContext testContextInstance;

        /// <summary>
        ///Ottiene o imposta il contesto del test che fornisce
        ///le informazioni e le funzionalità per l'esecuzione del test corrente.
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

        #region Attributi di test aggiuntivi
        //
        // È possibile utilizzare i seguenti attributi aggiuntivi per la scrittura dei test:
        //
        // Utilizzare ClassInitialize per eseguire il codice prima di eseguire il primo test della classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Utilizzare ClassCleanup per eseguire il codice dopo l'esecuzione di tutti i test della classe
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Utilizzare TestInitialize per eseguire il codice prima di eseguire ciascun test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Utilizzare TestCleanup per eseguire il codice dopo l'esecuzione di ciascun test
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void CheckSommaCorretta()
        {
            //
            // TODO: aggiungere qui la logica del test
            //
            Form1 myForm = new Form1();
            myForm.tb1.Text = "1";
            myForm.tb2.Text = "2";
            myForm.Somma_Click(null, null);
            Assert.AreEqual("3", myForm.textBox3.Text, "somma non corretta");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "carattere non valido")]
        public void CheckGestioneCaratteri()
        {
            //
            // TODO: aggiungere qui la logica del test
            //
            Form1 myForm = new Form1();
            myForm.tb1.Text = "a";
            myForm.tb2.Text = "2";
            myForm.Somma_Click(null, null);
        }
    }
}
