using System;
using Microsoft.Data.SqlClient;

namespace CarRentalSystem01
{

    public class CarManager
    {

        private List<Car> newCar = new List<Car>();

        public void AddCar(Car car)
        {
            newCar.Add(car);
            Console.WriteLine("Successfully Added");
        }

        public void ReadCar()
        {
            if (newCar.Count == 0)
            {
                Console.WriteLine("No Cars available.");
            }
        }

        public void UpdateCar(int id, string brand, string model, decimal rentalPrice)
        {
            var car = newCar.Find(x => x.CarId == id);
            if(car != null){
                car.Brand = brand;
                car.Model = model;
                car.RentalPrice = rentalPrice;
            }
        }

        public void DeleteCar(int id){
            newCar.RemoveAll(x => x.CarId == id);
        }

       
    }

}