using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gepjarmuKereskedes.Infrastructure
{
    public interface ISiteRepository
    {
        Site Get(int id);
        List<Site> GetAll();
        List<Site> GetByAddress(string address);

    }
}
