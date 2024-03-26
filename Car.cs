using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    

    public class Car : Vehicle
    {
        // Additional properties specific to cars
        public int Seats { get; set; }
        public string EngineType { get; set; }
        public string Transmission { get; set; }
        public bool Convertible { get; set; }

        // Constructor
        public Car(string model, string manufacturer, int year, double rentalPrice,
                   int seats, string engineType, string transmission, bool convertible)
                   : base(model, manufacturer, year, rentalPrice)
        {
            Seats = seats;
            EngineType = engineType;
            Transmission = transmission;
            Convertible = convertible;
        }

        // Override DisplayDetails method to include car-specific properties
        public override void DisplayDetails()
        {
            base.DisplayDetails(); // Call base class method to display common vehicle properties
            Console.WriteLine($"Seats: {Seats}");
            Console.WriteLine($"Type of Engine: {EngineType}");
            Console.WriteLine($"Transmission: {Transmission}");
            Console.WriteLine($"Convertible: {(Convertible ? "Yes" : "No")}");
        }
    }

}
