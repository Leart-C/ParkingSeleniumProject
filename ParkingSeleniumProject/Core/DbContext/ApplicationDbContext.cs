using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ParkingSeleniumProject.Core.Entities;

namespace ParkingSeleniumProject.Core.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
         
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<ParkingReservationManager> ParkingReservationManagers { get; set; }

    }
}
