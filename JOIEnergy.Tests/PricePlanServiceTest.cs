using JOIEnergy.Domain;
using JOIEnergy.Services;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace JOIEnergy.Tests
{
    public class PricePlanServiceTest
    {
        private PricePlanService _pricePlanService;
        private readonly Mock<MeterReadingService> _mockMeterReadingService;
        private List<PricePlan> _pricePlans;

        public PricePlanServiceTest()
        {
            _mockMeterReadingService = new Mock<MeterReadingService>();
            _pricePlanService = new PricePlanService(_pricePlans, _mockMeterReadingService.Object);

            _mockMeterReadingService.Setup(service => service.GetReadings(It.IsAny<string>())).Returns(new List<ElectricityReading>(){new ElectricityReading(),
                new ElectricityReading()});
        }
    }
}