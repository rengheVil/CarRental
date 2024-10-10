using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.FileIO;
using System.CarManager;

namespace CarRentalSystem01{
public class Programme{
    public static void Main(string[] args){
//  int option = 0;
CarManager carManager= new CarManager();
Console.WriteLine("Car Rental Management System ");



 while (true)
        {
            Console.WriteLine("1. Add a Bike");
            Console.WriteLine("2. View All Bikes");
            Console.WriteLine("3. Update a Bike");
            Console.WriteLine("4. Delete a Bike");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option:");


            string option = Console.ReadLine();
            if (option == "1")
            {
                Console.Write("Enter the Car Id: ");
                int carId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Car Brand: ");
                string brand = Console.ReadLine();
                Console.Write("Enter the Car Model: ");
                string model = Console.ReadLine();
                Console.Write("Enter the Car RentalPrice: ");
                decimal rentalPrice = decimal.Parse(Console.ReadLine());
                carManager.CreateCar(new Car(carId, brand, model, rentalPrice));
            }
            else if (option == "2")
            {
                carManager.ReadCars();
            }
            else if (option == "3")
            {
                Console.Write("Enter the Car Id: ");
                int carId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the New Brand: ");
                string newbrand = Console.ReadLine();
                Console.Write("Enter the New Car Model: ");
                string newmodel = Console.ReadLine();
                Console.Write("Enter the New Car RentalPrice: ");
                decimal newrentalPrice = decimal.Parse(Console.ReadLine());
                carManager.UpdateCar(carId,newbrand,newmodel,newrentalPrice);
            }
            else if(option == "4"){
                Console.Write("Enter the Car Id");
                int carId = Convert.ToInt32(Console.ReadLine());
                carManager.DeleteCar(carId);
            }
            else if(option == "5"){
                return;
            }
            else{
                Console.WriteLine("Enter the correct option");
            }
        }
    }

}

}







// while(true){
// Console.WriteLine("1. Add a Car");
// Console.WriteLine("2. View All Cars");
// Console.WriteLine("3. Update a Car ");
// Console.WriteLine("4. Delete a Car ");
// Console.WriteLine("5. Exit ");
// Console.WriteLine(" Choosh an option: ");

// if (!int.TryParse(Console.ReadLine(), out  option)){
//     Console.WriteLine("Invalid input. Please enter a number between 1 to 5. ");
//     continue;
// }

// switch(option){
//     case 1:
//     Console.Write("Enter Car Id : ");
//     int bikeId = int.Parse(Console.ReadLine());
//     Console.Write("Enter Brand: ");
//     string brand = Console.ReadLine();
//     Console.Write("Enter Model:");
//     string model = Console.ReadLine();
//     decimal rentalPrice = carRepository.ValidateCarRentalPrice();
    
//     Car newCar = new Car(carId,brand, model,rentalPrice);
//     carRepository.AddCar(newCar);
//     break;
// }

//          string option = Console.ReadLine();
//             if (option == "1")
//             {
//                 Console.Write("Enter the Car Id: ");
//                 int carId = Convert.ToInt32(Console.ReadLine());
//                 Console.Write("Enter the Car Brand: ");
//                 string brand = Console.ReadLine();
//                 Console.Write("Enter the Car Model: ");
//                 string model = Console.ReadLine();
//                 Console.Write("Enter the Car RentalPrice: ");
//                 decimal rentalPrice = decimal.Parse(Console.ReadLine());
//                 carManager.CreateCar(new Car(carId, brand, model, rentalPrice));
//             }
//             else if (option == "2")
//             {
//                 carManager.ReadCars();
//             }
//             else if (option == "3")
//             {
//                 Console.Write("Enter the Car Id: ");
//                 int carId = Convert.ToInt32(Console.ReadLine());
//                 Console.Write("Enter the New Brand: ");
//                 string newbrand = Console.ReadLine();
//                 Console.Write("Enter the New Car Model: ");
//                 string newmodel = Console.ReadLine();
//                 Console.Write("Enter the New Car RentalPrice: ");
//                 decimal newrentalPrice = decimal.Parse(Console.ReadLine());
//                 carManager.UpdateCar(carId,newbrand,newmodel,newrentalPrice);
//             }
//             else if(option == "4"){
//                 Console.Write("Enter the Car Id");
//                 int carId = Convert.ToInt32(Console.ReadLine());
//                 carManager.DeleteCar(carId);
//             }
//             else if(option == "5"){
//                 return;
//             }
//             else{
//                 Console.WriteLine("Enter the correct option");
//             }
//         }
//     }

// }

// }

