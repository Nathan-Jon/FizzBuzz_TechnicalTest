using FizzBuzz_TechnicalTest;

namespace UnitTestProject
{
    [TestClass]
    public class FizzBuzzUnitTests
    {
        IFizzBuzzGenerator _fizzBuzzGenerator { get; set; }

        [TestInitialize]
        public void Initialise()
        {
            _fizzBuzzGenerator = new FizzBuzzGenerator(3,5);
        }

        [TestMethod]
        public void GetFizzBuzz_0Values_Return_Empty_Success()
        {
            int[] values = new int[0];
            Assert.AreEqual(0, _fizzBuzzGenerator.GetFizzBuzzFromValues(values).Count());
        }

        [TestMethod]
        public void GetFizzBuzz_1Value_Return_Fizz_Success()
        {
            int[] values = new int[] { 3 };
            Assert.AreEqual("Fizz", _fizzBuzzGenerator.GetFizzBuzzFromValues(values).FirstOrDefault());
        }

        [TestMethod]
        public void GetFizzBuzz_1Value_Return_Buzz_Success()
        {
            int[] values = new int[] { 5 };
            Assert.AreEqual("Buzz", _fizzBuzzGenerator.GetFizzBuzzFromValues(values).FirstOrDefault());
        }

        [TestMethod]
        public void GetFizzBuzz_1Value_Return_FizzBuzz_Success()
        {
            int[] values = new int[] { 15 };
            Assert.AreEqual("FizzBuzz", _fizzBuzzGenerator.GetFizzBuzzFromValues(values).FirstOrDefault());
        }

        [TestMethod]
        public void GetFizzBuzz_3Values_Return_FizzBuzz_Success()
        {
            int[] values = new int[] { 15, 30, 45 };

            Assert.IsTrue(!_fizzBuzzGenerator.GetFizzBuzzFromValues(values).Any(x => x != "FizzBuzz"));
        }

        [TestMethod]
        public void GetFizzBuzz_3Values_Return_Fizz_Success()
        {
            int[] values = new int[] { 3,33,66};

            Assert.IsTrue(!_fizzBuzzGenerator.GetFizzBuzzFromValues(values).Any(x => x != "Fizz"));
        }

        public void GetFizzBuzz_3Values_Return_Buzz_Success()
        {
            int[] values = new int[] { 5, 20, 140 };

            Assert.IsTrue(!_fizzBuzzGenerator.GetFizzBuzzFromValues(values).Any(x => x != "Buzz"));
        }




        [TestMethod]
        public void GetValuesToInterpret_Request1_Returns1()
        {
            int minValue = 0;
            int maxValue = 1;

            Assert.AreEqual(maxValue, _fizzBuzzGenerator.GetValuesToInterpret(minValue, maxValue).Count());
        }

        [TestMethod]
        public void GetValuesToInterpret_Request10_Returns10()
        {
            int minValue = 0;
            int maxValue = 10;

            Assert.AreEqual(maxValue, _fizzBuzzGenerator.GetValuesToInterpret(minValue, maxValue).Count());
        }

        [TestMethod]
        public void GetValuesToInterpret_Request100_Returns100()
        {
            int minValue = 0;
            int maxValue = 100;

            Assert.AreEqual(maxValue, _fizzBuzzGenerator.GetValuesToInterpret(minValue, maxValue).Count());
        }

        [TestMethod]
        public void GetValuesToInterpret_Request1000_Returns1000()
        {
            int minValue = 0;
            int maxValue = 1000;

            Assert.AreEqual(maxValue, _fizzBuzzGenerator.GetValuesToInterpret(minValue, maxValue).Count());
        }
    }
}