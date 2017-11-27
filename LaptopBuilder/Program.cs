using System;

namespace LaptopBuilder
{
  class Program
  {
    static void Main(string[] args)
    {
      LaptopBuilder gamingLaptopBuilder = new GamingLaptopBuilder();
      LaptopBuilder businessLaptopBuilder = new BusinessLaptopBuilder();
      BuyLaptop shop = new BuyLaptop();

      shop.SetLaptopBuilder(businessLaptopBuilder);
      shop.ConstructLaptop();

      Laptop laptop = shop.GetLaptop();

      Console.WriteLine(laptop.ToString());
      Console.ReadKey();
    }
  }
}
