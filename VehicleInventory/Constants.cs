using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInventory
{
    class Constants
    {
        public const string constBMW = "BMW";
        public const string constTesla = "Tesla";
        public const string constHonda = "Honda";
        public const string constBMWDesc = "© BMW AG, Munich, Germany";
        public const string constTeslaDesc = "(Batteries Included!)";

        public const int constOilChangeDays = 90;
        public const int constOilChangeMiles = 3000;
        public const int constHondaOilChangeMonths = 7;
        public const int constHondaOilChangeMiles = 8000;

        public enum Colors
        {
            Black,
            Blue,
            Red,
            White,
            Gray
        };

        public enum SortType
        {
            VIN,
            Model,
            Year
        }

    }
}
