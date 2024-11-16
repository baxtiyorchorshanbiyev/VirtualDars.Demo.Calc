namespace VirtualDars.Demo.Calc;
public class Calculator
{
  public void Start()
  {
    while (true)
    {
      Console.WriteLine("Kalkulyator dasturi ishga tushdi");
      double firstNumber = ParseNumber();
      string operation = ValidatingOperation();
      double secondNumber = ParseNumber();
      var result = Calculate(firstNumber, secondNumber, operation);
      Console.WriteLine($"Natija: {firstNumber} {operation} {secondNumber} = {result}");
    }
  }
  private double ParseNumber()
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
  private string ValidatingOperation()
  {
    string operation = string.Empty;

    while (operation != "+" && operation != "-" &&
      operation != "*" && operation != "/" &&
      operation != "^")
    {
      Console.WriteLine("Amalni kiriting (+ - * / ^)");
      operation = Console.ReadLine();

    }
    return operation;
  }

  private double Calculate(double firstNumber, double secondNumber, string operation)
  {
    double result = operation switch
    {
      "+" => firstNumber + secondNumber,
      "-" => firstNumber - secondNumber,
      "*" => firstNumber * secondNumber,
      "^" => Math.Pow(firstNumber, secondNumber),
      "/" => secondNumber != 0 ? firstNumber / secondNumber : throw new DivideByZeroException("O ga bo'lib bo'lmaydi"),
    };
    return result;
  }
}
