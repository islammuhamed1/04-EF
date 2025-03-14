using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EF.Entities
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
    }
    public  class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public override string ToString()
        {
            return $"Car = Id = {Id} , Make = {Make} , Model = {Model} , NumberOfDoors = {NumberOfDoors}";
        }
    }
    public class Truck : Car
    {
        public int LoadCapacity { get; set; }
    }

}
