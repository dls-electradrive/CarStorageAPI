﻿using CarStorageApi.Models;

namespace CarStorageApi.Repositories
{
    public interface ICarRepository
    {
        public List<Car> GetCars();
    }
}