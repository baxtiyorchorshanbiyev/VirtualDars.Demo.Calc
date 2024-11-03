
using VirtualDars.Demo.Calc;
// MathDemo.DoCalculations();
// LoopsAndArrayDemo.ForLoop();
// LoopsAndArrayDemo.Arrays();
// LoopsAndArrayDemo.ForEachLoop();

while (true)
{
  Console.WriteLine("Kalkulyator dasturi ishga tushdi");
  double firstNumber = ParseNumber();
  string operation = ValidatingOperation();
  if (operation == "**")
  {
    SquareOperation(firstNumber);
    continue;
  }
  double secondNumber = ParseNumber();
  ShowResult(firstNumber, secondNumber, operation);
}

double ParseNumber()
{
  bool isParse = false;
  double result = 0;
  while (!isParse)
  {
    Console.WriteLine("Sonni kiriting!");
    string numberString = Console.ReadLine();
    isParse = double.TryParse(numberString, out result);
  }
  return result;
}
string ValidatingOperation()
{
  string operation = string.Empty;

  while (operation != "+" && operation != "-" &&
    operation != "*" && operation != "/" &&
    operation != "**" && operation != "^")
  {
    Console.WriteLine("Amalni kiriting (+ - * / ** ^)");
    operation = Console.ReadLine();

  }

  return operation;
}

void ShowResult(double firstNumber, double secondNumber, string operation)
{
  double result = operation switch
  {
    "+" => firstNumber + secondNumber,
    "-" => firstNumber - secondNumber,
    "*" => firstNumber * secondNumber,
    "^" => Math.Pow(firstNumber, secondNumber),
    "/" => secondNumber != 0 ? firstNumber / secondNumber : throw new DivideByZeroException("O ga bo'lib bo'lmaydi"),
  };
  Console.WriteLine($"Natija: {firstNumber} {operation} {secondNumber} = {result}");
}



void SquareOperation(double number)
{
  double squaredResult = DoubleNumber(number);
  Console.WriteLine($"Natija: {number} ning kvadrati = {squaredResult}");
}

double DoubleNumber(double firstNumber)
{
  return Math.Pow(firstNumber, 2);

}