using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInventory
{
    class VehicleRepository
    {
        public static List<Vehicle> vehicles = new List<Vehicle>();
        public List<Vehicle> GetAllVehicles()
        {
            return vehicles;
        }

        public Vehicle GetVehicleById(int id)
        {
            return vehicles.FirstOrDefault(v => v.getId() == id);
        }

        public List<Vehicle> GetVehiclesByManufacturer(Manufacturer manufacturer)
        {
            return vehicles.FindAll(vehicles => vehicles.getManufacturer() == manufacturer);
        }

        public List<Vehicle> GetVehiclesByYear(int year)
        {
            return vehicles.FindAll(vehicles => vehicles.getYear() == year);
        }

        public void InsertVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
        }
    }
}
