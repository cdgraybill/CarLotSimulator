using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var ford = new Car();
            ford.Year = "2015";
            ford.Make = "Ford";
            ford.Model = "Explorer";
            ford.EngineNoise = "vroom";
            ford.HonkNoise = "honk";
            ford.IsDriveable = true;

            ford.MakeEngineNoise(ford.EngineNoise);
            ford.MakeHonkNoise(ford.HonkNoise);
            Console.ReadLine();


            Car chevy = new Car()
            {
                Year = "2015",
                Make = "Chevy",
                Model = "Malibu",
                EngineNoise = "vroom",
                HonkNoise = "honk",
                IsDriveable = true
            };

            chevy.MakeEngineNoise(chevy.EngineNoise);
            chevy.MakeHonkNoise(chevy.HonkNoise);
            Console.ReadLine();


            var honda = new Car();
            honda.Year = "2015";
            honda.Make = "Honda";
            honda.Model = "Accord";
            honda.EngineNoise = "vroom";
            honda.HonkNoise = "honk";
            honda.IsDriveable = true;

            honda.MakeEngineNoise(honda.EngineNoise);
            honda.MakeHonkNoise(honda.HonkNoise);
            Console.ReadLine();
        }
    }
}
                //TODO

                //Create a seperate class file called Car
                //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
                //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
                //The methods should take one string parameter: the respective noise property


                //Now that the Car class is created we can instanciate 3 new cars
                //Set the properties for each of the cars
                //Call each of the methods for each car

                //*************BONUS*************//

                // Set the properties utilizing the 3 different ways we learned about, one way for each car

                //*************BONUS X 2*************//

                //Create a CarLot class
                //It should have at least one property: a List of cars
                //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
                //At the end iterate through the list printing each of car's Year, Make, and Model to the console
