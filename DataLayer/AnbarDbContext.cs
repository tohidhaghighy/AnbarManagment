using DomainLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class AnbarDbContext:DbContext
    {
        public AnbarDbContext() : base("AnbarDb")
        {
            Database.SetInitializer<AnbarDbContext>(new CreateDatabaseIfNotExists<AnbarDbContext>());

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<InstallDevice> InstallDevices { get; set; }
    }
}
