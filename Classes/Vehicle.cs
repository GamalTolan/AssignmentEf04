using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEf04.Classes
{
    public abstract class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
    public class Car : Vehicle
    { 
        public int NumberOfDoors { get; set; }
    }

    public class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }
    }

}
