using FizzBuzz_TechnicalTest.ExtensionMethods;
namespace UnitTestProject
{
    [TestClass]
    public class ExtensionMethodsUnitTests
    {
        [TestMethod]
        public void IsNullOrEmpty_Null_ReturnsTrue()
        {
            string? testValue = null;
            Assert.IsTrue(testValue.IsNullOrEmpty());
        }
        [TestMethod]
        public void IsNullOrEmpty_Empty_ReturnsTrue()
        {
            string testValue = "";
            Assert.IsTrue(testValue.IsNullOrEmpty());
        }

        [TestMethod]
        public void IsNullOrEmpty_Word_ReturnsFalse()
        {
            string testValue = "Word";
            Assert.IsFalse(testValue.IsNullOrEmpty());
        }
    }
}