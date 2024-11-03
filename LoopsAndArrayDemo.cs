using System;

namespace VirtualDars.Demo.Calc;

public class LoopsAndArrayDemo
{
  public static void ForLoop()
  {
    //1. 0dan 9gacha bo'lgan sonlarni consolega chiqaradi
    for (int i = 0; i < 10; i++)
    {
      Console.WriteLine(i);
    }

    //2. 1 dan 10 gacha bo'lgan sonlarning yig'indisini console ga chiqaring

    int result = 0;
    for (int i = 0; i <= 10; i++)
    {
      result += i;
    }
    Console.WriteLine(result);

    //3. Console da kiritilgan sonning karra jadvalini chiqaring

    Console.WriteLine("Sonni kiriting:");
    int number1 = Convert.ToInt32(Console.ReadLine());
    int number2;
    for (number2 = 1; number2 <= 10; number2++)
    {
      Console.WriteLine($"{number1} X {number2} = {number1 * number2}");
    }

    //4. pastga qarab yurish 

    for (int i = 100; i >= 1; i--)
    {
      Console.WriteLine(i);
    }

  }


  public static void Arrays()
  {
    //Array - Qatorning uzunligini boshida beriladi va keyin o'zgartirib bo'lmaydi
    //Qatorga yangi element qo'shib bo'lmaydi
    //Qatordan elementni o'chirib bo'lmaydi
    //Qatordan indekslash 0 dan boshlanadi

    int[] numbersArray = new int[9];
    numbersArray[0] = 1;
    numbersArray[1] = 2;
    numbersArray[2] = 3;
    numbersArray[3] = 4;
    numbersArray[4] = 5;

    //yoki
    int[] numbersArray2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    //yoki
    var numbersArray3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    //2. yuqoridagi qatordagi elemntariga bitta oldingi 
    // elementing qiymatini qo'shing va ularni consolega chiqaring

    for (int i = 0; i < numbersArray3.Length; i++)
    {

      if (i > 0)
      {
        numbersArray3[i] += numbersArray3[i - 1];
      }
      Console.WriteLine(numbersArray3[i]);
    }

    // Berilgan arrayda duplicate larni qaytarsin

    string[] fruitsArray = { "Anor", "Behi", "Uzum", "Olma", "Nok", "Anor", "Shaftoli", "Olcha", "Olma", "Xurmo", "Uzum" };
    Console.WriteLine("Qaytarilgan mevalar");

    for (int i = 0; i < fruitsArray.Length; i++)
    {
      bool isDuplicate = false;

      for (int j = i + 1; j < fruitsArray.Length; j++)
      {
        if (fruitsArray[i] == fruitsArray[j])
        {
          isDuplicate = true;
          break;
        }
      }

      if (isDuplicate)
      {
        Console.WriteLine(fruitsArray[i]);

      }
    }

  }

  public static void Lists()
  {
    // List - ro'yhatda elementlar soni cheklanmangan
    // Ro'yxat bilan ishlash qatorga qaraganda ancha qulayroq
    // Ro'yxatga keyinchalik ham yangi element qo'shish va mavjud elementni o'chirib tashlash mumkin
    // Ro'yxatda ham indekslash 0 dan boshlanadi

    //Ro'yxatni e'lon qilish
    //1.

    List<string> thankYouWords = new List<string>();

    //2.
    var thankYouWords2 = new List<string>();

    //3.
    List<string> thankYouWords3 = new();

    //4
    var thankYouWords4 = new List<string> { "rahmat", "arzimaydi" };

    //ro'yxatda oxiriga yangi element qo'shish

    thankYouWords4.Add("thank you");
    var otherThankYouWords = new List<string> { "1", "2", "3", "4" };

    thankYouWords4.AddRange(otherThankYouWords);

    //Ro'yxatning orasiga yangi element qo'shish
    thankYouWords4.Insert(3, "Raxmet");

    //Ro'yxatdan elementni o'chirib tashlash
    thankYouWords4.Remove("1");
    thankYouWords4.RemoveAt(4);

    //royxatda elementlarni shart orasida o'chirish
    thankYouWords4.RemoveAll((word) => word.Contains(" "));

    thankYouWords3.Clear();

  }


  public static void ForEachLoop()
  {
    var participants = new List<string> { "Abror", "Avaz", "Aziz" };

    //1

    foreach (string item in participants)
    {
      Console.WriteLine($"Assalomu alaykum: {item}");
    }

    //2
    participants.ForEach((gretting) => Console.WriteLine($"Assalomu alaykum: {gretting}"));

    //3
    double totalPrice = 0;

    var shoppingList = new List<double> { 1, 3, 40, 40.12 };
    var itemNo = 0;
    shoppingList.ForEach((item) =>
    {
      totalPrice += item;
      Console.WriteLine($"{itemNo}: {item}");
      itemNo++;
    });
    Console.WriteLine($"Jami narxi: {totalPrice}");

    string[] fruits = { "apple", "banana", "cherry", "banana", "apple", "kiwi", "cherry", "grape" };


    for (int i = 0; i < fruits.Length; i++)
    {
      bool isDublicate = false;

      for (int j = i + 1; j < fruits.Length; j++)
      {

        if (fruits[i] == fruits[j])
        {
          isDublicate = true;
          break;
        }
      }
      if (isDublicate)
      {
        Console.WriteLine($"Qaytarilgan meva: {fruits[i]}");
      }
    }


  }
}

