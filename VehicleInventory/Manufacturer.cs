using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInventory
{
    class Manufacturer
    {
        private string name { get; set; }
        private string country { get; set; }
        public string getName()
        {
            return name;
        }
        public void setName(string Name)
        {
            name = Name;
        }
        public string getCountry()
        {
            return country;
        }
        public void setCountry(string Country)
        {
            country = Country;
        }

        public Manufacturer()
        {

        }

        public Manufacturer(string Name, string Country)
        {
            name = Name;
            country = Country;
        }

    }
}
