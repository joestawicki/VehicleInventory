using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VehicleInventory.Constants;

namespace VehicleInventory
{
    class VehicleService
    {
        public void AddMileage(Vehicle vehicle, int mileage)
        {
            int newMileage = vehicle.getMileage() + mileage;
            vehicle.setMileage(newMileage);
        }

        public List<Vehicle> GetSortedVehicles(List<Vehicle> vehicleList, SortType sortType)
        {
            List<Vehicle> sortedVehicleList = new List<Vehicle>();

            switch (sortType)
            {
                case SortType.VIN:
                    sortedVehicleList.AddRange(vehicleList.OrderBy(v => v.getVin()));
                    break;
                case SortType.Model:
                    sortedVehicleList.AddRange(vehicleList.OrderBy(v => v.getModel()));
                    break;
                case SortType.Year:
                    sortedVehicleList.AddRange(vehicleList.OrderBy(v => v.getYear()));
                    break;
            }

            return sortedVehicleList;
        }
    }
}
