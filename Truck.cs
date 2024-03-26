using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    

    public class Truck : Vehicle
    {
        // Additional properties specific to trucks
        public double Capacity { get; set; }
        public string TruckType { get; set; }
        public bool FourWheelDrive { get; set; }

        // Constructor
        public Truck(string model, string manufacturer, int year, double rentalPrice,
                     double capacity, string truckType, bool fourWheelDrive)
                     : base(model, manufacturer, year, rentalPrice)
        {
            Capacity = capacity;
            TruckType = truckType;
            FourWheelDrive = fourWheelDrive;
        }

        // Override DisplayDetails method to include truck-specific properties
        public override void DisplayDetails()
        {
            base.DisplayDetails(); // Call base class method to display common vehicle properties
            Console.WriteLine($"Capacity: {Capacity} tons");
            Console.WriteLine($"Truck Type: {TruckType}"); 
            Console.WriteLine($"Four Wheel Drive: {(FourWheelDrive ? "Yes" : "No")}");
        }
    }

}
