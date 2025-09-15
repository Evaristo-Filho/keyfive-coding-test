using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KeyfiveLiveCodingSession;

public interface ITelemetryManager
{
    // 
    void Add(ITelemetry telemetry);
    void Remove(Guid deviceId);
    ITelemetry? Get(Guid deviceId);
    IEnumerable<ITelemetry> List();
    double CalculateAverage(ITelemetry.Units? Units);
}

