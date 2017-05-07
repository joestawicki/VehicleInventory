using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInventory
{
    class LastOilChange
    {
        private DateTime date { get; set; }
        private int mileage { get; set; }
        public DateTime getDate()
        {
            return date;
        }
        public void setDate(DateTime Date)
        {
            date = Date;
        }
        public int getMileage()
        {
            return mileage;
        }
        public void setMileage(int Mileage)
        {
            mileage = Mileage;
        }

        public LastOilChange()
        {
            date = DateTime.MinValue;
            mileage = 0;
        }

        public LastOilChange(DateTime Date, int Mileage)
        {
            date = Date;
            mileage = Mileage;
        }
    }
}
