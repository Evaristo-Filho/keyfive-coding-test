
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Dynamic;
using System.Formats.Tar;

namespace KeyfiveLiveCodingSession;
using static KeyfiveLiveCodingSession.ITelemetry;

// Implement the Telemetry class using the ITelemetry interface. For bonus points, use a record instead of a class.

public record struct Telemetry(ref readonly Guid DeviceId, ref readonly string Name, double Value, ref readonly Units Unit) : ITelemetry
{

    public DateTime Timestamp { get { return DateTime.Now; } }

    public void Display()
    {
        Debug.WriteLine(this.ToString());
    }

    public void UpdateValue(double newValue)
    {
        this.Value = newValue;
    }
}
