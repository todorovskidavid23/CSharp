using System;
using System.Collections.Generic;

namespace TaxiManager9000.Domain.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public DateTime LicensePlateExpieryDate { get; set; }
        public List<Driver> AsignedDrivers { get; set; } = new List<Driver>();
    }
}
