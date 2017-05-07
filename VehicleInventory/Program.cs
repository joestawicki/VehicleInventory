using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VehicleInventory.TestData;
using static VehicleInventory.Constants;
using static VehicleInventory.BusinessLogic;

namespace VehicleInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test();
            VehicleRepository vehRepository = new VehicleRepository();
            vehRepository.InsertVehicle(vehicle1);
            vehRepository.InsertVehicle(vehicle2);
            vehRepository.InsertVehicle(vehicle3);
            vehRepository.InsertVehicle(vehicle4);
            vehRepository.InsertVehicle(vehicle5);
            vehRepository.InsertVehicle(vehicle6);
            vehRepository.InsertVehicle(vehicle7);
            vehRepository.InsertVehicle(vehicle8);
            vehRepository.InsertVehicle(vehicle9);
            vehRepository.InsertVehicle(vehicle10);
            Console.WriteLine("**Vehicle Inventory**");
            foreach (Vehicle veh in vehRepository.GetAllVehicles())
            {
                Console.WriteLine(veh.ToString());
            }
            Console.WriteLine("**Vehicles Requiring Oil Changes**");
            foreach (Vehicle veh in vehRepository.GetAllVehicles())
            {
                if (NeedsOilChange(veh))
                    Console.WriteLine(veh.ToString());
            }
            Console.WriteLine("Press Enter to Close");
            Console.ReadLine();

        }

        //static void Test()
        //{
        //    VehicleRepository vehRepository = new VehicleRepository();
        //    vehRepository.InsertVehicle(vehicle1);
        //    vehRepository.InsertVehicle(vehicle2);
        //    vehRepository.InsertVehicle(vehicle3);
        //    vehRepository.InsertVehicle(vehicle4);
        //    vehRepository.InsertVehicle(vehicle5);
        //    vehRepository.InsertVehicle(vehicle6);
        //    vehRepository.InsertVehicle(vehicle7);
        //    vehRepository.InsertVehicle(vehicle8);
        //    vehRepository.InsertVehicle(vehicle9);
        //    vehRepository.InsertVehicle(vehicle10);

        //    foreach (Vehicle veh in vehRepository.GetAllVehicles())
        //    {
        //        Console.WriteLine(veh.ToString());
        //    }

        //    VehicleService vehService = new VehicleService();

        //    Console.WriteLine("******SORT BY VIN******");
        //    foreach (Vehicle veh in vehService.GetSortedVehicles(vehRepository.GetAllVehicles(), SortType.VIN))
        //    {
        //        Console.WriteLine(veh.ToString());
        //    }

        //    Console.WriteLine("******SORT BY Model******");
        //    foreach (Vehicle veh in vehService.GetSortedVehicles(vehRepository.GetAllVehicles(), SortType.Model))
        //    {
        //        Console.WriteLine(veh.ToString());
        //    }

        //    Console.WriteLine("******SORT BY Year******");
        //    foreach (Vehicle veh in vehService.GetSortedVehicles(vehRepository.GetAllVehicles(), SortType.Year))
        //    {
        //        Console.WriteLine(veh.ToString());
        //    }


        //    Console.WriteLine("******Remove Vehicle 2******");
        //    vehRepository.RemoveVehicle(vehicle2);
        //    foreach (Vehicle veh in vehRepository.GetAllVehicles())
        //    {
        //        Console.WriteLine(veh.ToString());
        //    }

        //    Console.WriteLine("******Get Vehicle id: 3******");
        //    Console.WriteLine(vehRepository.GetVehicleById(3).ToString());

        //    Console.WriteLine("******Get Vehicles Year: 2009******");
        //    foreach (Vehicle veh in vehRepository.GetVehiclesByYear(2009))
        //    {
        //        Console.WriteLine(veh.ToString());
        //    }

        //    Console.WriteLine("******Get Vehicles Manufacturer: BMW******");
        //    foreach (Vehicle veh in vehRepository.GetVehiclesByManufacturer(BMW))
        //    {
        //        Console.WriteLine(veh.ToString());
        //    }

        //    Console.WriteLine("******Add Mileage******");
        //    Console.WriteLine(vehicle8.getMileage());
        //    vehService.AddMileage(vehicle8, 2500);
        //    Console.WriteLine(vehicle8.getMileage());
        //}
    }
}
