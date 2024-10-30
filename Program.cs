
while (true)
{
  Console.WriteLine("Kalkulyator dasturi ishga tushdi");
  double firstNumber = ParseNumber();
  string operation = ValidatingOperation(firstNumber);
  if (operation == "**")
  {
    double squaredResult = DoubleNumber(firstNumber);
    Console.WriteLine($"Natija: {firstNumber} {operation} = {squaredResult}");
    continue;
  }

  double secondNumber = ParseNumber();
  ShowResult(firstNumber, secondNumber, operation);
}

double ParseNumber()
{
  bool isParse = false;
  double result = 0;
  Console.WriteLine("Sonni kiriting!");
  while (!isParse)
  {
    string numberString = Console.ReadLine();
    isParse = double.TryParse(numberString, out result);
    if (!isParse)
    {
      Console.WriteLine("Iltimos faqat son kiriting!");
    }
  }

  return result;
}
string ValidatingOperation(double firstNumber)
{
  bool isParse = false;
  string result = string.Empty;
  while (!isParse)
  {
    Console.WriteLine("Amalni kiriting (+ - * / **)");
    string operationString = Console.ReadLine();
    if (operationString == "+" || operationString == "-" ||
    operationString == "*" || operationString == "/" || operationString == "**")
    {
      isParse = true;
      result = operationString;
      Console.WriteLine($"{firstNumber} {operationString}");
    }
  }
  return result;
}
void ShowResult(double firstNumber, double secondNumber, string operation)
{
  double result = operation switch
  {
    "+" => firstNumber + secondNumber,
    "-" => firstNumber - secondNumber,
    "*" => firstNumber * secondNumber,
    "/" => secondNumber != 0 ? firstNumber / secondNumber : throw new DivideByZeroException("O ga bo'lib bo'lmaydi"),
  };
  Console.WriteLine($"Natija: {firstNumber} {operation} {secondNumber} = {result}");
}

double DoubleNumber(double firstNumber)
{
  return Math.Pow(firstNumber, 2);

}