using FizzBuzz_TechnicalTest;

namespace UnitTestProject
{
    [TestClass]
    public class FizzBuzzUnitTests
    {
        IFizzBuzzGenerator _fizzBuzzGenerator;

        [TestInitialize]
        public void Initialise()
        {
            _fizzBuzzGenerator = new FizzBuzzGenerator();
        }

        [TestMethod]
        public void GetFizzBuzz_0Values_Return_Empty_Success()
        {
            int[] values = new int[0];
            Assert.AreEqual(0, _fizzBuzzGenerator.GetFizzBuzz(values).Count());
        }

        [TestMethod]
        public void GetFizzBuzz_1Value_Return_Fizz_Success()
        {
            int[] values = new int[] { 3 };
            Assert.AreEqual("Fizz", _fizzBuzzGenerator.GetFizzBuzz(values).FirstOrDefault());
        }

        [TestMethod]
        public void GetFizzBuzz_1Value_Return_Buzz_Success()
        {
            int[] values = new int[] { 5 };
            Assert.AreEqual("Buzz", _fizzBuzzGenerator.GetFizzBuzz(values).FirstOrDefault());
        }
        [TestMethod]
        public void GetFizzBuzz_1Value_Return_FizzBuzz_Success()
        {
            int[] values = new int[] { 15 };
            Assert.AreEqual("FizzBuzz", _fizzBuzzGenerator.GetFizzBuzz(values).FirstOrDefault());
        }

    }
}