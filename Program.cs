using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dotnetcore
{
    class test
    {
        
        static void Main(string[] args)
        {
            #region ?? operátor
            //int? a = null;

            //int? b = a ?? -1; // Ha a nem null akkor az értéket adja át, ha nem akkor -1 lesz

            //Console.WriteLine(b);
            #endregion

            #region Query expression

            //string[] words = { "apple", "strawberry", "grape", "peach", "banana" };
            //IEnumerable<string> wordQuery = 
            //                from word in words
            //                where word[0] == 'g'
            //                select word;

            //foreach (string i in wordQuery)
            //{
            //    Console.WriteLine(i + " ");
            //}

            //// Specify the data source.
            //int[] scores = new int[] { 97, 92, 81, 60 };

            //// Define the query expression.
            //IEnumerable<int> scoreQuery =
            //    from score in scores
            //    where score > 80
            //    select score;

            //// Execute the query.
            //foreach (int i in scoreQuery)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.ReadKey();
            #endregion

            #region OOP examples

            
            // create 2 new objects
            Vehicle car1 = new Vehicle();
            car1.manufacturer = "Studebaker";
            car1.model = "Avanti";

            Vehicle car2 = new Vehicle();
            car2.manufacturer = "Hudson";
            car2.model = "Hornet";

            // create 2 ojects and both are same as reference
            Vehicle yourCar;
            yourCar = new Vehicle();
            yourCar.manufacturer = "Rambler";
            Vehicle yourSpousalCar = yourCar;
            yourSpousalCar.manufacturer = "Trooper";

            // different between objects

            bool equal;
            equal = (car1 == car2); // false
            equal = (yourCar == yourSpousalCar); // true

            // yourCar will be null object and after it gives new object refernce so it will be another object
            yourCar = null; // the garbage collector clean it from the memory
            yourCar = new Vehicle();
            yourCar.manufacturer = "Hudson";

            // create new Motor class object to largeMotor
            Motor largerMotor = new Motor();
            largerMotor.power = 230;
            largerMotor.displacement = 4.0;

            // in yourCar class has a motor reference and is a null value, add largeMotor (Motor class) object reference to yourCar (Vehicle class) 
            yourCar.motor = largerMotor;

            // both reference are equal
            Motor m = yourCar.motor;
            equal = (m.displacement == yourCar.motor.displacement);

            // overwrite all largeMotor items
            largerMotor.power = 300;
            largerMotor.displacement = 5.0;

            // increment static variable 
            Vehicle newCar = new Vehicle();
            newCar.licensePlate = "gdg244";
            Vehicle.numberOfCars++; // this static variable will be increments all objects of Vehicle
            #endregion


            Console.ReadKey();
        }

    }

}
