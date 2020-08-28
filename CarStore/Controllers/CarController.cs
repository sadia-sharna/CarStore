using Repositories.IRepository;
using Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarStore.Controllers
{
    public class CarController : ApiController
    {
        private ICarRepository _carRepository;

        public CarController(ICarRepository carRepository) {
            _carRepository = carRepository;
        }

        public int Get()
        {
            //CarRepository carrepo = new CarRepository();
            return _carRepository.getAllCars();
            //return carrepo.getAllCars();
            
        }

    }
}
