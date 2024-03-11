using System;
namespace CarLotSimulator
{
    public class Car
    {
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - done
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - done
        //The methods should take one string parameter: the respective noise property - done

        public Car()
        {
            ParkingLot.numberOfCars++;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = Model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

     

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }

    }
        
}

