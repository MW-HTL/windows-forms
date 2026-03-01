using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorHub
{
    // SensorReading class: container for sensor data
    public class SensorReading
    {
        public DateTime Timestamp { get; private set; }     /* time of sensor reading */
        public int Sequence { get; private set; }           /* number of reading/measurement */
        public double Temperature { get; private set; }     /* temperature value */

        public SensorReading(DateTime timestamp, int sequence, double temperature)
        {
            Timestamp = timestamp;
            Sequence = sequence;
            Temperature = temperature;
        }
    }
}
