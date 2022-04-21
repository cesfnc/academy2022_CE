using System;

namespace Academy.Common.Entities
{
    public class Vehicle
    { 
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Seats { get; set; }

        public Vehicle()
        {
        
        }

        public Vehicle(string brand, string model)
        { 
            Brand = brand;
            Model = model;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - Year;
        }


        public string GetDescription()
        {
            return $"{Brand}-{Model}, year {Year}";
        }
    }
}
