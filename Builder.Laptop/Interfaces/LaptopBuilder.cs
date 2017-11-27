
namespace Builder.Laptop
{
  public abstract class LaptopBuilder
  {
    protected Laptop Laptop { get; private set; }

    public void CreateNewLaptop()
    {
      Laptop = new Laptop();
    }

    public Laptop GetMyLaptop()
    {
      return Laptop;
    }

    public abstract void SetName();
    public abstract void SetMonitorResolution();
    public abstract void SetProcessor();
    public abstract void SetMemory();
    public abstract void SetSSD();
    public abstract void SetBattery();
  }
}
