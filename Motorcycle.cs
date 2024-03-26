﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    

    public class Motorcycle : Vehicle
    {
        // Additional properties specific to motorcycles
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing { get; set; }

        // Constructor
        public Motorcycle(string model, string manufacturer, int year, double rentalPrice,
                          int engineCapacity, string fuelType, bool hasFairing)
                          : base(model, manufacturer, year, rentalPrice)
        {
            EngineCapacity = engineCapacity;
            FuelType = fuelType;
            HasFairing = hasFairing;
        }

        // Override DisplayDetails method to include motorcycle-specific properties
        public override void DisplayDetails()
        {
            base.DisplayDetails(); // Call base class method to display common vehicle properties
            Console.WriteLine($"Engine Capacity: {EngineCapacity} cc");
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Has Fairing: {(HasFairing ? "Yes" : "No")}");
        }
    }

}
