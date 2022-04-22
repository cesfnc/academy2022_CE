using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Common.Entities
{
    public class Rent
    {
        public int ID { get; set; } //TODO potrei assegnarlo in automatico con id progressivo
        public DateTime From { get; set; }
        public DateTime To { 
            get 
            { 
                return From.AddDays(Days);
            } 
        }

        public int Days { get; set; }

        public Customer Customer { get; set; }

        public Vehicle Vehicle { get; set; }

        public int Cost {
            get
            {
                if (Vehicle == null)
                {
                    return 0;
                }

                return Days * Vehicle.DailyPrice;
            }
        }


        public Rent(Customer customer, Vehicle vehicle, DateTime from, int days)
        {
            Customer = customer;
            Vehicle = vehicle;
            From = from;
            Days = days;

            //TODO
            // customer esiste?
            // vehicle esiste?
            // from è coerente
            // days è coerente (> 0 && < valore massimo)

            if (customer.IsNewDriver && vehicle.IsForNewDriver)
            { 
                //TODO
                // Il cliente non può guidare l'auto da noleggiare
            }
        }

        public override string ToString()
        {
            return $"Noleggio {ID} - Date: {From.ToShortDateString()}-{To.ToShortDateString()}\n"+
                $"\tVeicolo {Vehicle}\n" +
                $"\tCliente {Customer}\n" +
                $"Costo totale: {Cost:C}";
        }
    }
}
