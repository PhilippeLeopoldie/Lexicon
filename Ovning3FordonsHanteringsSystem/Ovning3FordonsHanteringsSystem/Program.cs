﻿using Ovning3FordonsHanteringsSystem.SystemError;
using Ovning3FordonsHanteringsSystem;
using Ovning3FordonsHanteringsSystem.Vehicles;


internal class Program
{
    static void Main(string[] args)
    {
       
        try
        {
            Console.WriteLine("------Del 2 Display List of SystemError objects-------");
            List<SystemError> errorList = new List<SystemError>
            {
                new TransmissionError(),
                new EngineFailureError(),
                new BrakeFailureError()
            };
            foreach (SystemError error in errorList)
            {
                Util.Log(error.ErrorMessage());
            }
            Console.WriteLine();

            Console.WriteLine("-----Create 4 vehicles-------");
            VehicleHandler.CreateVehicle(new Car("Peugot", "3008", 2012, 1208, 24));
            VehicleHandler.CreateVehicle(new Motorcycle("Yamaha", "Model Yamaha", 2024, 500, true ));
            VehicleHandler.CreateVehicle(new Truck("Scania","r500", 2018, 8000, 3000));
            VehicleHandler.CreateVehicle(new ElectricScooter("Xiaomi", "m365", 2021, 12, 12.5));
            VehicleHandler.DisplayVehicles();
            Console.WriteLine();

            Console.WriteLine("-------modify the brand of the first vehicle----------");
            VehicleHandler.UpdateBrand(VehicleHandler.ListVehicles.First(), "Volvo");
            VehicleHandler.DisplayVehicles();
            Console.WriteLine();

            Console.WriteLine("-------modify the vehicle 'xiamo'----------");
            VehicleHandler.UpdateVehicle(VehicleHandler.ListVehicles
                .First(vehicle => vehicle.Brand == "xiaomi"),
                "segway", "Minebot Max", 2022, 19
                );
            VehicleHandler.DisplayVehicles();
            Console.WriteLine();

            Console.WriteLine("----Del4: loop throw list-------");
            foreach(var vehicle in  VehicleHandler.ListVehicles)
            {
                Util.Log(vehicle.StartEngine());
                Util.Log($"{vehicle.Stats()}");
                if(vehicle is ICleanable cleanable)
                {
                    Util.Log(cleanable.Clean());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
