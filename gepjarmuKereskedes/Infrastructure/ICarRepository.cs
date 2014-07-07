using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gepjarmuKereskedes.Infrastructure
{
    public interface ICarRepository
    {
        Car Get(int id);
        List<Car> GetAll();
        List<Car> GetByModel(string model);
    }
}

