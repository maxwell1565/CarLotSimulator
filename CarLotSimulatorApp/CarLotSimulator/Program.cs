using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {


        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.


            var lot = new ParkingLot();


            //Create a seperate class file called Car - done

            //Now that the Car class is created we can instanciate 3 new cars - done


            var ford = new Car();
            ford.Year = 2015;
            ford.Make = "ford";
            ford.Model = "flex";
            ford.EngineNoise = "vroom";
            ford.HonkNoise = "beep";
            ford.IsDriveable = true;

            lot.Cars.Add(ford);

            var chevy = new Car()
            {
                Year = 2007,
                Make = "chevy",
                Model = "silverado",
                EngineNoise = "vrrrrrr",
                HonkNoise = "beepppp",
                IsDriveable = true,

            };
            lot.Cars.Add(chevy);

            var toyota = new Car(2011, "toyota", "Camry", "rmmmmm", "beeeeeep", true)
            {

            };
            lot.Cars.Add(toyota);

            //Set the properties for each of the cars - done
            //Call each of the methods for each car - done

            Console.WriteLine($"Cars created = {ParkingLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}; Make: {car.Make}; Model: {car.Model}");
            }

            ford.MakeEngineNoise();
            ford.MakeHonkNoise();
            chevy.MakeEngineNoise();
            chevy.MakeHonkNoise();
            toyota.MakeEngineNoise();
            toyota.MakeHonkNoise();

            

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car - done

            //*************BONUS X 2*************//

            //Create a CarLot class - done
            //It should have at least one property: a List of cars - done
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console - done
        }
    }
}
