
namespace Builder.Laptop
{
  //director
  public class BuyLaptop
  {
    private LaptopBuilder laptopBuilder;

    public void SetLaptopBuilder(LaptopBuilder laptopBuilder)
    {
      this.laptopBuilder = laptopBuilder;
    }

    public Laptop GetLaptop()
    {
      return laptopBuilder.GetMyLaptop();
    }

    public void ConstructLaptop()
    {
      laptopBuilder.CreateNewLaptop();
      laptopBuilder.SetName();
      laptopBuilder.SetBattery();
      laptopBuilder.SetMemory();
      laptopBuilder.SetMonitorResolution();
      laptopBuilder.SetProcessor();
      laptopBuilder.SetSSD();
    }
  }
}
