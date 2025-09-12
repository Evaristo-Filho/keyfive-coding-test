
using System.ComponentModel.DataAnnotations;

namespace KeyfiveLiveCodingSession;
using static KeyfiveLiveCodingSession.ITelemetry;

// Implement the Telemetry class using the ITelemetry interface. For bonus points, use a record instead of a class.

public record Telemetry : ITelemetry
{
    public Telemetry(Guid deviceID, string name, double value, Units unit ) { }
    public Guid DeviceId => throw new NotImplementedException();

    public string Name => throw new NotImplementedException();

    public DateTime Timestamp => throw new NotImplementedException();

    public double Value => throw new NotImplementedException();

    public ITelemetry.Units Unit => throw new NotImplementedException();

    public void Display()
    {
        throw new NotImplementedException();
    }

    public void UpdateValue(double newValue)
    {
        throw new NotImplementedException();
    }
}
