﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Vehicle
    {
        public Guid VehicleId { get; set; }
        public string? VehicleName { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? Model { get; set; }
        public string? Color { get; set; }
        public bool? BookingStatus { get; set; }
        public bool? MaintainanceStatus { get; set; }
        public int Mileage { get; set; }

        // Add Relationships !
        // One Vehicle can have many Bookings
        public List<Booking>? Bookings { get; set; }
        // One Vehicle can have many Bookings
        public List<Maintenance>? Maintenances {get; set;}
        // A Vehicle can be Associated with only One Staff Member
        // at a time
        public Staff? Chauffeur {get;set;}

    }
}
