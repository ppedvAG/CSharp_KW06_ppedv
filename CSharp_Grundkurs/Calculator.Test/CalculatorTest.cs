using Calculator.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        private ICalculator calculator;
        
        [TestInitialize] //Init-Methode für Testaufbau (Instanzen die öfters in Test verwendet werden) 
        public void InitTest()
        {
            //Bei Test mit Datenbanken -> Testdaten werden erstellt
            calculator = new MyCalculator();
        }

        [TestMethod]
        public void AddidtionTest()
        {
            int param1 = 11;
            int param2 = 22;

            int result = calculator.Addition(param1, param2);
            Assert.AreEqual((param1+param2), result);
        }

        [TestMethod]
        public void SubtraktionTest()
        {
           
            int param1 = 11;
            int param2 = 22;

            int result = calculator.Subtraktion(param1, param2);

            Assert.AreEqual((param1 - param2), result);
        }

        [TestMethod]
        public void MultiplikationTest()
        {
            
            int param1 = 11;
            int param2 = 22;

            int result = calculator.Multiplikation(param1, param2);

            Assert.AreEqual((param1 * param2), result);
        }

        [TestMethod]
        public void DivisionTest()
        {
            
            int param1 = 11;
            int param2 = 22;

            int result = calculator.Division(param1, param2);

            Assert.AreEqual((param1 /  param2), result);
        }

        [TestMethod]
        public void DivisionDivideByZeroExceptionTest()
        {
            try
            {
               
                int param1 = 11;
                int param2 = 0;

                int result = calculator.Division(param1, param2);


                //Wenn ich bis hier her komme, ist in der Methode Division keine Exceptioin geflogen
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is DivideByZeroException);
            }
        }


        [TestCleanup]
        public void Cleanup()
        {
            //Aufräum Methode für Unit Test. 

            //Bei Test mit Datenbanken -> Testdaten werden wieder gelöscht 
        }
    }
}
