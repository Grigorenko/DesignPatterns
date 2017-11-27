using System.Text;

namespace Builder.Laptop
{
  public class Laptop
  {
    public string Name { get; set; }
    public string MonitorResolution { get; set; }
    public string CPU { get; set; }
    public string Memory { get; set; }
    public string SSD { get; set; }
    public string Battery { get; set; }

    public override string ToString()
    {
      StringBuilder builder = new StringBuilder();

      builder.AppendLine($"{Name}")
        .AppendLine($"\tMonitor resolution: {MonitorResolution}")
        .AppendLine($"\tCPU: {CPU}")
        .AppendLine($"\tMemmory: {Memory}")
        .AppendLine($"\tSSD: {SSD}")
        .AppendLine($"\tBattery: {Battery}");

      return builder.ToString();
    }
  }
}
