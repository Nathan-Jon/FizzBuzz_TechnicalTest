namespace UnitTestProject
{
    [TestClass]
    public class IntExtensionMethodsUnitTests
    {
        [TestMethod]
        public void HasRemainder_DivideBy0_ReturnsTrue()
        {
            int testValue = 10;
            int dividingNumber = 0;

            Assert.IsTrue(testValue.HasRemainder(dividingNumber));
        }

        [TestMethod]
        public void HasRemainder_NoRemainder_ReturnsFalse()
        {
            int testValue = 4;
            int dividingNumber = 2;

            Assert.IsFalse(testValue.HasRemainder(dividingNumber));
        }

        [TestMethod]
        public void HasRemainder_YesRemainder_ReturnsTrue()
        {
            int testValue = 4;
            int dividingNumber = 3;

            Assert.IsTrue(testValue.HasRemainder(dividingNumber));
        }
    }
}