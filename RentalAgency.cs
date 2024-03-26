using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
   

    public class RentalAgency
    {
        private Vehicle[] fleet; // Array to store instances of vehicles
        private double totalRevenue; // Property to track total revenue

        // Constructor
        public RentalAgency(int capacity)
        {
            fleet = new Vehicle[capacity];
            totalRevenue = 0;
        }

        // Property for TotalRevenue
        public double TotalRevenue
        {
            get { return totalRevenue; }
            private set { totalRevenue = value; }
        }

        public IEnumerable<object> Fleet { get; internal set; }

        // Method to add vehicles to the fleet
        public void AddVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < fleet.Length; i++)
            {
                if (fleet[i] == null)
                {
                    fleet[i] = vehicle;
                    return;
                }
            }
            Console.WriteLine("Fleet is full. Cannot add more vehicles.");
        }

        // Method to remove vehicles from the fleet
        public void RemoveVehicle(string model)
        {
            for (int i = 0; i < fleet.Length; i++)
            {
                if (fleet[i] != null && fleet[i].Model == model)
                {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                    fleet[i] = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
                    Console.WriteLine($"Vehicle '{model}' removed from the fleet.");
                    return;
                }
            }
            Console.WriteLine($"Vehicle '{model}' not found in the fleet.");
        }

        // Method to rent a vehicle
        public void RentVehicle(string model, int days)
        {
            foreach (var vehicle in fleet)
            { 
                if (vehicle != null && vehicle.Model == model)
                {
                    double rentalPrice = vehicle.RentalPrice * days;
                    totalRevenue += rentalPrice;
                    Console.WriteLine($"Vehicle '{model}' rented for {days} days. Total cost: ${rentalPrice}");
                    return;
                }
            }
            Console.WriteLine($"Vehicle '{model}' not found in the fleet.");
        }
    }

}
