namespace KeyfiveLiveCodingSession;

public interface ITelemetry
{
    Guid DeviceId { get; }
    string Name { get; }
    DateTime Timestamp { get; }
    double Value { get; }
    Units Unit { get; }

    // Methods

    /// <summary>
    /// UpdateValue: Update the 'Value' and 'Timestamp' properties
    /// </summary>
    /// <param name="newValue"></param>
    void UpdateValue(double newValue);

    /// <summary>
    /// Display:Write to the console a string show the DeviceId, Timestamp, Value, and Unit
    /// </summary>
    void Display();

    public enum Units
    {
        Celsius,
        Fahrenheit
    }
}


