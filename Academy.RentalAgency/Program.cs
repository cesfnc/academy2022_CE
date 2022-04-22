// See https://aka.ms/new-console-template for more information
using Academy.Common.Entities;
using Academy.Common.Entities.Vehicles;

Console.WriteLine("Noleggio Veicoli\n");

Customer customer = new Customer("MROGLL", "Mario", "Gallo", true);
Vehicle vehicle = new Car("PLT", "Model A", 45, false);
Rent rent = new Rent(customer, vehicle, DateTime.Now, 3);
Console.WriteLine(rent);

Vehicle vehicle1 = new Track() { 
    Brand = "OM",
    IsForNewDriver = false,
    Color = "Rosso",
    DailyPrice = 300,
    KgCapacity = 3500,
    Model = "T1", 
    Plate = "MMM234EE",
    Year =1918
};
var rent1 = new Rent(customer, vehicle1, DateTime.Now, 3);
Console.WriteLine(rent1);


Track vehicle2 = new Track();
var x = vehicle2.KgCapacity;

Vehicle vehicle3 = new Track();

//var y = vehicle3.KgCapacity;
var y = ((Track)vehicle3).KgCapacity;

object obj = new Car("", "", 1, false);

var sss = obj.ToString();
Vehicle castV = (Vehicle)obj;
//castV.Model
Car castC = (Car)obj;
//castC.Seats

Console.WriteLine("");
