using JOIEnergy.Domain;
using JOIEnergy.Interfaces;
using System;
using System.Collections.Generic;

namespace JOIEnergy.Services
{
    public class MeterReadingService(Dictionary<string, List<ElectricityReading>> meterAssociatedReadings) : IMeterReadingService
    {
        private Dictionary<string, List<ElectricityReading>> _meterAssociatedReadings { get; set; } = meterAssociatedReadings;

        public List<ElectricityReading> GetReadings(string smartMeterId)
        {
            if (_meterAssociatedReadings.ContainsKey(smartMeterId))
            {
                return _meterAssociatedReadings[smartMeterId];
            }
            return new List<ElectricityReading>();
        }

        public void StoreReadings(string smartMeterId, List<ElectricityReading> electricityReadings)
        {
            if (!_meterAssociatedReadings.ContainsKey(smartMeterId))
            {
                _meterAssociatedReadings.Add(smartMeterId, new List<ElectricityReading>());
            }

            electricityReadings.ForEach(electricityReading => _meterAssociatedReadings[smartMeterId].Add(electricityReading));
        }
    }
}