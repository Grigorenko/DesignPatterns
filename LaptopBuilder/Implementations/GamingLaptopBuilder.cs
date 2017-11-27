
namespace LaptopBuilder
{
  public class GamingLaptopBuilder : LaptopBuilder
  {
    public override void SetName()
    {
      Laptop.Name = "Gaming Laptop";
    }

    public override void SetBattery()
    {
      Laptop.Battery = "6 lbs, 45Wh";
    }

    public override void SetMemory()
    {
      Laptop.Memory = "DDR 4 16384 Mb 2400 MHz";
    }

    public override void SetMonitorResolution()
    {
      Laptop.MonitorResolution = "1920x1080";
    }

    public override void SetProcessor()
    {
      Laptop.CPU = "Intel Core i7 7700 HQ";
    }

    public override void SetSSD()
    {
      Laptop.SSD = "512 Gb, Intel";
    }
  }
}
