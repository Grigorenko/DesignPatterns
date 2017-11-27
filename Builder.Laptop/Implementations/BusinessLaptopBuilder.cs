
namespace Builder.Laptop
{
  public class BusinessLaptopBuilder : LaptopBuilder
  {
    public override void SetName()
    {
      Laptop.Name = "Business Laptop";
    }

    public override void SetBattery()
    {
      Laptop.Battery = "3 lbs, 35Wh";
    }

    public override void SetMemory()
    {
      Laptop.Memory = "DDR 4 8192 Mb 1600 MHz";
    }

    public override void SetMonitorResolution()
    {
      Laptop.MonitorResolution = "1366x760";
    }

    public override void SetProcessor()
    {
      Laptop.CPU = "Intel Core i3 380m";
    }

    public override void SetSSD()
    {
      Laptop.SSD = "120Gb, Goodram";
    }
  }
}
