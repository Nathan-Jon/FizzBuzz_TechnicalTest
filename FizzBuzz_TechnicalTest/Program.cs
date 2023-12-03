using FizzBuzz_TechnicalTest;
// See https://aka.ms/new-console-template for more information

IFizzBuzzGenerator fizzBuzzGenerator = new FizzBuzzGenerator(3,5);

IEnumerable<int> values = fizzBuzzGenerator.GetValuesToInterpret(0, 101);

foreach (var item in fizzBuzzGenerator.GetFizzBuzzFromValues(values))
{
    Console.WriteLine(item);
}

