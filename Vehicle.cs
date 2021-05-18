using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetcore
{
    class Motor
    {
        public int power;
        public double displacement;
    }
    class Vehicle
    {
        // publics
        public string model;
        public string manufacturer;
        public int numOfDoors;
        public int nimOfWheel;
        public Motor motor;
        public string licensePlate;
        // statics
        public static int numberOfCars;
    }
}
