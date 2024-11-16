namespace VirtualDars.Demo.Calc;

public class MathDemo
{
  public static void DoCalculations()
  {
    Console.WriteLine($"2ning  3chi darajasi: {Math.Pow(2, 3)}");
    Console.WriteLine($"81ning ildizi: {Math.Sqrt(81)}");
    Console.WriteLine($"Yaxlitlash: {Math.Round(5.319)}");
    Console.WriteLine($"Faqat tepaga yaxlitlash: {Math.Ceiling(5.319)}");
    Console.WriteLine($"Faqat pastga  yaxlitlash: {Math.Floor(5.319)}");
    Console.WriteLine($"Kasr sondan faqat butun qisimini qoldirish: {Math.Truncate(5.319)}");
    Console.WriteLine($"5.19 ning absolut qiymati: {Math.Abs(5.319)}");
    Console.WriteLine($"-5.19 ning absolut qiymati: {Math.Abs(-5.319)}");
    Console.WriteLine($"PI: {Math.PI}");
  }

}
