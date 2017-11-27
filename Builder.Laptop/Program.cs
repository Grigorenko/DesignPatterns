using System;

namespace Builder.Laptop
{
  class Program
  {
    static void Main(string[] args)
    {
      BuyLaptop shop = new BuyLaptop();

      shop.SetLaptopBuilder(Program.UserOrderProcess());
      shop.ConstructLaptop();

      Laptop laptop = shop.GetLaptop();

      Console.WriteLine(laptop.ToString());
      Console.ReadKey();
    }

    private static LaptopBuilder UserOrderProcess()
    {
      Console.WriteLine("Welcome!");
      Console.WriteLine("Choose configuration:");
      Console.WriteLine("\t1 - Gaming laptop");
      Console.WriteLine("\t2 - Business laptop");

      while (true)
      {
        string userChoose = Console.ReadLine();

        if (string.Equals(userChoose, "1"))
          return new GamingLaptopBuilder();

        else if (string.Equals(userChoose, "2"))
          return new BusinessLaptopBuilder();

        Console.WriteLine("Write down 1 or 2");
      }
    }
  }
}
