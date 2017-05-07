using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VehicleInventory.Constants;

namespace VehicleInventory
{
    static class BusinessLogic
    {
        public static string GetExtraWording(Vehicle vehicle)
        {
            if (vehicle.getManufacturer().getName() == constBMW)
                return constBMWDesc;
            else if (vehicle.getManufacturer().getName() == constTesla)
                return constTeslaDesc;

            return "";
        }

        public static bool NeedsOilChange(Vehicle vehicle)
        {
            if (vehicle.getManufacturer().getName() == constTesla)
                return false;
            else if (vehicle.getManufacturer().getName() == constHonda)
            {
                if (vehicle.getLastOilChange().getDate().AddMonths(constHondaOilChangeMonths) <= DateTime.Now ||
                    vehicle.getMileage() - vehicle.getLastOilChange().getMileage() >= constHondaOilChangeMiles)
                {
                    return true;
                }
            }
            else
            {
                if (vehicle.getLastOilChange().getDate().AddDays(constOilChangeDays) <= DateTime.Now ||
                    vehicle.getMileage() - vehicle.getLastOilChange().getMileage() >= constOilChangeMiles)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
