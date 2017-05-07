using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VehicleInventory.Constants;

namespace VehicleInventory
{
    class TestData
    {
        public static Manufacturer Toyota = new Manufacturer("Toyota", "Japan");
        public static Manufacturer Chevrolet = new Manufacturer("Chevrolet", "United States");
        public static Manufacturer BMW = new Manufacturer("BMW", "Germany");
        public static Manufacturer Hyundai = new Manufacturer("Hyundai", "South Korea");
        public static Manufacturer Honda = new Manufacturer("Honda", "Japan");
        public static Manufacturer Tesla = new Manufacturer("Tesla", "United States");

        public static LastOilChange veh1OilChange = new LastOilChange(); //needs oil change
        public static LastOilChange veh2OilChange = new LastOilChange(new DateTime(2017, 1, 1), 15000); //needs oil change
        public static LastOilChange veh3OilChange = new LastOilChange(new DateTime(2017, 5, 1), 9000); //no oil change
        public static LastOilChange veh4OilChange = new LastOilChange(new DateTime(2016, 12, 1), 53000);//needs oil change
        public static LastOilChange veh5OilChange = new LastOilChange(new DateTime(2016, 12, 1), 23000); //no oil change
        public static LastOilChange veh6OilChange = new LastOilChange(); //no oil change
        public static LastOilChange veh7OilChange = new LastOilChange(new DateTime(2017, 4, 1), 49800); //needs oil change
        public static LastOilChange veh8OilChange = new LastOilChange(); //no oil change
        public static LastOilChange veh9OilChange = new LastOilChange(new DateTime(2017, 4, 1), 61013); //no oil change
        public static LastOilChange veh10OilChange = new LastOilChange(new DateTime(2017, 2, 1), 40089); //needs oil change

        public static Vehicle vehicle1 = new Vehicle(1, "1234A5678B90", BMW, "X6", 2009, 100, Colors.Blue, veh1OilChange);
        public static Vehicle vehicle2 = new Vehicle(2, "2334B5678PA0", Toyota, "RAV4", 2016, 25000, Colors.Blue, veh2OilChange);
        public static Vehicle vehicle3 = new Vehicle(3, "0234A5678B90", Chevrolet, "Traverse", 2009, 10000, Colors.Blue, veh3OilChange);
        public static Vehicle vehicle4 = new Vehicle(4, "Z3345AEB8B91", Hyundai, "Sonata", 2012, 55000, Colors.Blue, veh4OilChange);
        public static Vehicle vehicle5 = new Vehicle(5, "5434WR67DB90", Honda, "CR-V", 2013, 28005, Colors.Blue, veh5OilChange);
        public static Vehicle vehicle6 = new Vehicle(6, "1234A5678", Tesla, "Model S", 2010, 22065, Colors.Blue, veh6OilChange);
        public static Vehicle vehicle7 = new Vehicle(7, "8234A5678B90", Chevrolet, "Malibu", 2017, 53021, Colors.Blue, veh7OilChange);
        public static Vehicle vehicle8 = new Vehicle(8, "R234D56D8B9", Tesla, "Model 3", 2011, 75008, Colors.Blue, veh8OilChange);
        public static Vehicle vehicle9 = new Vehicle(9, "964A5678B950", Toyota, "Camry", 2005, 61030, Colors.Blue, veh9OilChange);
        public static Vehicle vehicle10 = new Vehicle(10, "1234A5678B91", BMW, "M5", 2014, 45038, Colors.Blue, veh10OilChange);

    }
}
