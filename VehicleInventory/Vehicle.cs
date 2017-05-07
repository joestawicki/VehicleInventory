using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VehicleInventory.TestData;
using static VehicleInventory.Constants;
using static VehicleInventory.BusinessLogic;
using static VehicleInventory.LastOilChange;

namespace VehicleInventory
{
    class Vehicle
    {
        private int id { get; set; }
        private string vin { get; set; }
        private string model { get; set; }
        private int year { get; set; }
        private int mileage { get; set; }
        private Colors color { get; set; }
        private Manufacturer manufacturer { get; set; }
        private LastOilChange lastOilChange { get; set; }

        public int getId()
        {
            return id;
        }

        public void setId(int Id)
        {
            id = Id;
        }
        public string getVin()
        { 
            return vin;
        }
        public void setVin(string Vin)
        {
            vin = Vin;
        }
        public string getModel()
        {
            return model;
        }
        public void setModel(string Model)
        {
            model = Model;
        }
        public int getYear()
        {
            return year;
        }
        public void setYear(int Year)
        {
            year = Year;
        }
        public int getMileage()
        {
            return mileage;
        }
        public void setMileage(int Mileage)
        {
            mileage = Mileage;
        }
        public Colors getColor()
        {
            return color;
        }
        public void setColor(Colors Color)
        {
            color = Color;
        }
        public Manufacturer getManufacturer()
        {
            return manufacturer;
        }
        public void setManufacturer(Manufacturer Manufacturer)
        {
            manufacturer = Manufacturer;
        }
        public LastOilChange getLastOilChange()
        {
            return lastOilChange;
        }
        public void setLastOilChange(LastOilChange LastOilChange)
        {
            lastOilChange = LastOilChange;
        }
        public Vehicle()
        {

        }

        public Vehicle(int Id, string Vin, Manufacturer Manufacturer, string Model, int Year, int Mileage, Colors Color, LastOilChange LastOilChange)
        {
            id = Id;
            vin = Vin;
            model = Model;
            year = Year;
            mileage = Mileage;
            manufacturer = Manufacturer;
            color = Color;
            lastOilChange = LastOilChange;
        }
        
        public override string ToString()
        {
            string vehString;
            vehString = "Color: " + color.ToString() + " Year: " + year.ToString() + " Manufacturer: " + manufacturer.getName() +
                " Model: " + model + " VIN: " + vin + " " + GetExtraWording(this);

            return vehString;
        }

    }
}
