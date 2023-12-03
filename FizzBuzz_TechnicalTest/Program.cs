using FizzBuzz_TechnicalTest;
// See https://aka.ms/new-console-template for more information

IFizzBuzzGenerator fizzBuzzGenerator = new FizzBuzzGenerator();

IEnumerable<int> values = Enumerable.Range(0, 101);

foreach (var item in fizzBuzzGenerator.GetFizzBuzz(values))
{
    Console.WriteLine(item);
}
