using _04_EF.Entities;
using Microsoft.EntityFrameworkCore;

namespace _04_EF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context.CompanyContext())
            {
                Car car = new Car
                {
                    Make = "Toyota",
                    Model = "Corolla",
                    NumberOfDoors = 4
                };
                Car car1 = new Car
                {
                    Make = "Tesla",
                    Model = "ModelX",
                    NumberOfDoors = 2
                };
                Truck truck = new Truck
                {
                    Make = "Ford",
                    Model = "F150",
                    LoadCapacity = 1000
                };
                Truck truck1 = new Truck
                {
                    Make = "Ford",
                    Model = "Fx50",
                    LoadCapacity = 700
                };
                context.Vehicles.Add(car);
                context.Add(car1);
                context.Set<Truck>().Add(truck);
                context.Add(truck1);
                context.SaveChanges();
                var cars = context.Vehicles.Where(x => EF.Property<string>(x, "VehicleType") == "Car").ToList();
                foreach (var item in cars)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
