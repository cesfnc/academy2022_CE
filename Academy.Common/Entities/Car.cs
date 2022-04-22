using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Common.Entities
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }


        public Car(string plate, string model, int dailyPrice, bool isForNewDrivers)
        {
            Plate = plate;
            Model = model;
            DailyPrice = dailyPrice;
            IsForNewDriver = isForNewDrivers;
        }

        public override string ToString()
        {
            string result = $"{Model} Targa '{Plate}' Prezzo giornaliero {DailyPrice:C}";
            if (IsForNewDriver)
            {
                result = result + " (Neo-patentati)";
            }
            return result;
        }
    }
}
