﻿using System.ComponentModel.DataAnnotations;

namespace ParkingSeleniumProject.Core.Entities
{
    public class ParkingSpace
    {
        [Key]
        public int Id { get; set; }
        public string Location { get; set; }
        public string Size { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public decimal PricePerHour { get; set; }

        // Navigation property for related ParkingSpaceManager
        public ICollection<ParkingSpaceManager> ParkingSpaceManagers { get; set; } = new List<ParkingSpaceManager>();

        // Navigation property for related AvailabilityMonitor
        public AvailabilityMonitor AvailabilityMonitor { get; set; }
    }
}
