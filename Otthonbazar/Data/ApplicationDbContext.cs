using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Otthonbazar.Data.EntityTypeConfigurations;

namespace Otthonbazar.Data {
    public class ApplicationDbContext : IdentityDbContext {
        public DbSet<City> Cities { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new CitySeedConfig());
            builder.ApplyConfiguration(new AdvertisementSeedConfig());
        }
    }
}
