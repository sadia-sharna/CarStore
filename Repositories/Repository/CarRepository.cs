using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
    public class CarRepository : ICarRepository
    {
        public int getAllCars()
        {
            return 746;
        }
    }
}
