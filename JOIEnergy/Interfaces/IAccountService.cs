using JOIEnergy.Enums;

namespace JOIEnergy.Interfaces
{
    public interface IAccountService
    {
        string GetPricePlanIdForSmartMeterId(string smartMeterId);
    }
}