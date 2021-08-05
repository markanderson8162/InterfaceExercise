using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car firstCar = new Car { Name = "Honda", IsElectric = true, IsSportsCar = false, NumberOfDealerships = 300 };
            Truck firstTruck = new Truck { Name = "GMC", BedSize = 6, IsDesiel = true, NumberOfDealerships = 550 };

            var suv = new SUV();
            var car = new Car();
            var truck = new Truck();

            suv.NumberOfSeats = 8;
            suv.Name = "Subaru";

            car.Wheels = 4;
            car.IsElectric = true;

            truck.BedSize = 6;
            truck.IsDesiel = true;

            string input = "";

            while(input != "exit")
			{
                Console.WriteLine("What car do you want? Type \"exit\" to exit");
                input = Console.ReadLine().ToLower();
                CarLot.numberOfCars++;
                if(input == "car")
				{
                    Console.WriteLine(firstCar);
                    Console.WriteLine(CarLot.numberOfCars);
                    Console.WriteLine("What else?");
                    input = Console.ReadLine().ToLower();
                }
                else if (input == "truck")
				{
                    Console.WriteLine(firstCar);
                    Console.WriteLine(CarLot.numberOfCars);
                    Console.WriteLine("What else?");
                    input = Console.ReadLine().ToLower();

                }
                else
				{
                    Console.WriteLine("I don't know what that is.");
                    input = Console.ReadLine();
				}
			}
        }
    }
}
