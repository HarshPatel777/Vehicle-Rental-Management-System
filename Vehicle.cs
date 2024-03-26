using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
   

    public class Vehicle
    {
        // Properties
        private string model;
        private string manufacturer;
        private int year;
        private double rentalPrice;

        // Constructor
        public Vehicle(string model, string manufacturer, int year, double rentalPrice)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalPrice;
        }

        // Getters and setters for properties
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value > 0 && value <= DateTime.Now.Year)
                    year = value;
                else
                    throw new ArgumentException("Invalid year.");
            }
        }

        public double RentalPrice
        {
            get { return rentalPrice; }
            set
            {
                if (value >= 0)
                    rentalPrice = value;
                else
                    throw new ArgumentException("Rental price cannot be negative.");
            }
        }

        // Method to display the vehicle's details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Rental Price: ${RentalPrice}");
        }
    }

}
