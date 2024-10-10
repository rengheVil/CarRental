using System;
using Microsoft.Data.SqlClient;

namespace CarRentalSystem01{

public class Car {
    public int CarId { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public decimal RentalPrice { get; set; }

public Car(int carId, string brand, string model, decimal rentalPrice) {
    CarId = carId;
    Brand = brand;
    Model = model;
    RentalPrice = rentalPrice;
    }

public override string ToString() {
    return $" ID: {CarId}, Brand: {Brand}, Model: {Model}, RentalPrice: {RentalPrice}" ;
}

}

    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public int MotorPower{get; set;}
          public ElectricCar(int carId, string brand, string model, decimal rentalPrice ,int batteryCapacity, int motorPower ) : base(carId, brand, model, rentalPrice)
        {
            BatteryCapacity = batteryCapacity;
            MotorPower = motorPower;

        }
    }

  public class PetrolCar : Car{
        public int FuelTankCapacity{get; set;}
        public int EngineCapacity {get; set;}
public PetrolCar(int carId, string brand, string model, decimal rentalPrice, int fuelTankCapacity, int engineCapacity ) : base(carId, brand, model, rentalPrice)
        {
            FuelTankCapacity = fuelTankCapacity;
            EngineCapacity = engineCapacity;
        }
        
    }



}