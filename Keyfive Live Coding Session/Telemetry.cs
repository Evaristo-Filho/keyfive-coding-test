
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Formats.Tar;

namespace KeyfiveLiveCodingSession;
using static KeyfiveLiveCodingSession.ITelemetry;

// Implement the Telemetry class using the ITelemetry interface. For bonus points, use a record instead of a class.

public record Telemetry : ITelemetry
{
    public Telemetry(Guid DeviceId, string Name, double Value, Units Units) { }
    public Guid DeviceId { get; }

    public string Name { get; }

    public DateTime Timestamp { get { return DateTime.Now; } }

    public double Value { get; set; }

    public ITelemetry.Units Unit { get; }

    public void Display()
    {
        Console.WriteLine(this.ToString());
    }

    public void UpdateValue(double newValue)
    {
       Value = newValue;
    }
}
