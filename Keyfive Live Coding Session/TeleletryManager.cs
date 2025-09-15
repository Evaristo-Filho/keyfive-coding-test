using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyfiveLiveCodingSession;

namespace KeyfiveLiveCodingSession
{
    public class TeleletryManager : ITelemetryManager
    {

        public List<ITelemetry> telemetries = new List<ITelemetry>();

        public void Add(ITelemetry telemetry)
        {
            if (telemetry != null)
                telemetries.Add(telemetry);
            else
                throw new Exception("error");
        }

        public double CalculateAverage(ITelemetry.Units? units = null)
        {
            var query = telemetries.Where(x => x == x);

            if (units == ITelemetry.Units.Fahrenheit)
                query = query.Where(x => x.Unit == ITelemetry.Units.Fahrenheit);
            if (units == ITelemetry.Units.Celsius)
                query = query.Where(x => x.Unit == ITelemetry.Units.Celsius);


            return query.Average(x => x.Value);
        }

        public double CalculateAverage(ITelemetry.Units? units = null, ITelemetry.Units convertedUnits = ITelemetry.Units.Celsius)
        {
            //Implemented after live code.
            var fValue = telemetries.Where(x => x.Unit == ITelemetry.Units.Fahrenheit).Sum(x => x.Value);
            var fCount = telemetries.Where(x => x.Unit == ITelemetry.Units.Fahrenheit).Count();

            var cValue = telemetries.Where(x => x.Unit == ITelemetry.Units.Celsius).Sum(x => x.Value);
            var cCount = telemetries.Where(x => x.Unit == ITelemetry.Units.Celsius).Count();

            if (convertedUnits == ITelemetry.Units.Fahrenheit)
            {
                var t = (fValue +
                        (cValue * 9 / 5) + (32 * cCount)) /
                        (fCount + cCount);
                                                
            }
            else
            {

            }

            return 0;
        }


        public ITelemetry? Get(Guid deviceId)
        {
            return telemetries
                .Where(x => x.DeviceId == deviceId)
                .FirstOrDefault();
        }

        public IEnumerable<ITelemetry> List()
        {
            return telemetries.ToList();
        }

        public void Remove(Guid deviceId)
        {
            var item = Get(deviceId);
            if (item != null)
                telemetries.Remove(item);
            //OK(succes argument)
            //NOK(Cause -- Notfound, Being used.)
        }
    }
}
