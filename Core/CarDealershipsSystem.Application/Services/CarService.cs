﻿using CarDealershipsSystem.Application.DTO;
using CarDealershipsSystem.Application.Interfaces;
using CarDealershipsSystem.DAL.Interfaces;
using CarDealershipsSystem.Domain;

namespace CarDealershipsSystem.Application.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IEnumerable<CarDTO> GetCars()
        {
            var cars = _carRepository.GetCars();
            var carsDTO = cars
                .Select(car => new CarDTO
            {
                IdCar = car.IdCar,
                IdBranch = car.IdBranch,
                Brand = car.Brand,
                Model = car.Model,
                BodyType = car.BodyType,
                CarExemplars = car.CarExemplars
                    .Select(carex => new CarExemplarDTO
                    {
                        VinNumber = carex.VinNumber,
                        IdCar = carex.IdCar,
                        HorsePower = carex.HorsePower,
                        Price = carex.Price,
                        Color = carex.Color,
                        YearOfAssembly = carex.YearOfAssembly
                    })
                    .ToList()
            });
            return carsDTO;
        }

        public int GetCarExemplarsCount(BranchDTO branch)
        {
            var cars = branch.Cars.ToList();
            int counter = 0;
            foreach (var car in cars)
            { 
                counter += car.CarExemplars.Count();
            }
            return counter;
        }

        public bool AddCar(string brand, string model, string bodyType, int idBranch)
        {
            var car = new Car()
            {
                Brand = brand,
                Model = model,
                BodyType = bodyType,
                IdBranch = idBranch
            };

            if (_carRepository.SaveCar(car))
            {
                return true;
            }
            return false;
        }
    }
}
