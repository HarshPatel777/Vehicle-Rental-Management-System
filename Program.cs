using System;
using Vehicle_Rental_Management_System;

class Program
{
    static void Main(string[] args)
    {
        // Create vehicles
        Car car = new Car("BMW", "Toyota", 2022, 50.0, 5, "V6", "Automatic", false);
        Truck truck = new Truck("Ford F-150", "Ford", 2021, 80.0, 3, "Pickup", true);
        Motorcycle motorcycle = new Motorcycle("Harley Davidson Street 750", "Harley Davidson", 2020, 40.0, 750, "Gasoline", true);

        // Display vehicle details
        Console.WriteLine("Car Details:");
        car.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Truck Details:");
        truck.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Motorcycle Details:");
        motorcycle.DisplayDetails();
        Console.WriteLine();

        // Create a rental agency
        RentalAgency agency = new RentalAgency(5);

        // Add vehicles to the agency's fleet
        agency.AddVehicle(car);
        agency.AddVehicle(truck);
        agency.AddVehicle(motorcycle);

        // Rent a vehicle
        Console.WriteLine("Renting a vehicle...");
        agency.RentVehicle("car", 5); // Rent the car for 5 days

        // Display total revenue
        Console.WriteLine($"Total Revenue: {agency.TotalRevenue:C}");
    }
}
