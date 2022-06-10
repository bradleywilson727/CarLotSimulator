using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingLot = new CarLot();

            //TODO

            //Create a seperate class file called Car DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() DONE
            //The methods should take one string parameter: the respective noise property DONE


            //Now that the Car class is created we can instanciate 3 new cars DONE
            //Set the properties for each of the cars DONE
            //Call each of the methods for each car DONE

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car DONE

            var firstCar = new Car();
            firstCar.Year = 2012;
            firstCar.Make = "Nissan";
            firstCar.Model = "Rogue";
            firstCar.EngineNoise = "Quiet";
            firstCar.HonkNoise = "Loud";
            firstCar.IsDriveable = true;

            parkingLot.ParkingLot.Add(firstCar);

            firstCar.MakeEngineNoise();

            firstCar.MakeHonkNoise();

            var secondCar = new Car() { Year = 2013, Make = "Kia", Model = "Sportage", EngineNoise = "Soft", HonkNoise = "Medium Loud", IsDriveable = true };

            parkingLot.ParkingLot.Add(secondCar);

            secondCar.MakeEngineNoise();

            secondCar.MakeEngineNoise();

            var thirdCar = new Car(2022, "Ford", "Bronco", "Medium Soft", "Loud", true);

            parkingLot.ParkingLot.Add(thirdCar);

            thirdCar.MakeEngineNoise();

            thirdCar.MakeHonkNoise();

            foreach(var car in parkingLot.ParkingLot)
            {
                Console.WriteLine($"This car is a {car.Year} {car.Make} {car.Model}.");
            }

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
