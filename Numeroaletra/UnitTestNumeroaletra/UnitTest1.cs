using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numeroaletra.Controllers;

namespace UnitTestNumeroaletra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLiteralGet1()
        {
            //Arrange
            LiteralController literalController = new LiteralController();
            int numero = 32;
            string expected = "TREINTA Y DOS";

            //Act
            string result = literalController.LiteralGet(numero);

            //Assert
            Assert.AreEqual(expected, result);

        }
    }
}
