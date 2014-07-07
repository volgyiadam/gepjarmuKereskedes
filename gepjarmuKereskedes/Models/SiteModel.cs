using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gepjarmuKereskedes.Models
{
    public class SiteModel
    {


        public int Id {get; set;}

        public int ZipCode {get; set;}

        public string Address {get; set;}

        public int ParkSlotCount {get; set;}

        public int ReservedCount {get; set;}
       
    }
}
 