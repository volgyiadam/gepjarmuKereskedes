using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gepjarmuKereskedes.Models
{
    public class CarModel
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public int Vintage { get; set; }
               
        public DateTime ProductionTime { get; set; }

        public string Condition { get; set; }


        public int PreviousOwners { get; set; }

        public int SiteId { get; set; }

    }

}