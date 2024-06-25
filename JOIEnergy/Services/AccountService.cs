using JOIEnergy.Enums;
using JOIEnergy.Interfaces;
using System;
using System.Collections.Generic;

namespace JOIEnergy.Services
{
    public class AccountService(Dictionary<string, string> smartMeterToPricePlanAccounts) : IAccountService
    {
        private Dictionary<string, string> _smartMeterToPricePlanAccounts { get; set; } = smartMeterToPricePlanAccounts;

        public string GetPricePlanIdForSmartMeterId(string smartMeterId)
        {
            if (!_smartMeterToPricePlanAccounts.ContainsKey(smartMeterId))
            {
                return null;
            }
            return _smartMeterToPricePlanAccounts[smartMeterId];
        }
    }
}