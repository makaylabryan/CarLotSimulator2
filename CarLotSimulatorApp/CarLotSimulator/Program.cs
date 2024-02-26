using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car ===DONE
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable  ===DONE
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()    ====DONE
            //The methods should take one string parameter: the respective noise property   ===DONE


            //Now that the Car class is created we can instanciate 3 new cars ===DONE
            //Set the properties for each of the cars ===DONE
            // Set the properties utilizing the 3 different ways we learned about, one way for each car  ===DONE
            //Call each of the methods for each car ====DONE

            
            //Instanciate the a Carlot at the
            //beginning of the program and
            //as you create a car add the car to the list.
            var lot = new CarLot();


            Car blakesCar = new Car()
            {
                Year = 2009,
                Make = "Chevy",
                Model = "Impala",
                EngineNoise = "chugchug",
                HonkNoise = "crickets",
                IsDriveable = false
            };
            blakesCar.MakeEngineNoise();
            blakesCar.MakeHonkNoise();

            lot.Cars.Add(blakesCar);

            Car fancyCar = new Car();
            fancyCar.Year = 2045;
            fancyCar.Make = "Tesla";
            fancyCar.Model = "wxyz";
            fancyCar.EngineNoise = "hmmmmmmmm";
            fancyCar.HonkNoise = "tweet tweet";
            fancyCar.IsDriveable = true;
            fancyCar.MakeHonkNoise();
            fancyCar.MakeEngineNoise();

            lot.Cars.Add(fancyCar);

            Car myCar = new Car(2015, "Kia", "Forte","Vroom","beep",true);
            myCar.MakeEngineNoise();
            myCar.MakeHonkNoise();

            lot.Cars.Add(myCar);

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"{car.Year}, {car.Make}, {car.Model}");
            }

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car ===DONE

            //*************BONUS X 2*************//

            //Create a CarLot class  ===DONE
            //It should have at least one property: a List of cars  ===DONE
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. ==DONE
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console ===DONE
        }
    }
}
