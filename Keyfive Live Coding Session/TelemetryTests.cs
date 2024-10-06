using Xunit;
using static KeyfiveLiveCodingSession.ITelemetry;

namespace KeyfiveLiveCodingSession;

public class TelemetryTests
{
    [Fact]
    public void Telemetry_UpdateValue_UpdatesValueAndTimestamp()
    {
        // Arrange
        var telemetry = new Telemetry(Guid.NewGuid(), "Device1", 22.0, Units.Celsius);
        var oldTimestamp = telemetry.Timestamp;

        // Act
        telemetry.UpdateValue(23.0);

        // Assert
        Assert.Equal(23.0, telemetry.Value);
        Assert.True(telemetry.Timestamp > oldTimestamp);
    }

    [Fact]
    public void Telemetry_DisplayTelemetry_DisplaysCorrectData()
    {
        // Arrange
        var telemetry = new Telemetry(Guid.NewGuid(), "DeviceA", 11.0, Units.Fahrenheit);

        // Act and Assert
        telemetry.Display();  // Verify manually that the output is correct
    }
}
