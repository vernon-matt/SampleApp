using VerticalAITCodeSample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VerticalAITCodeSample
{
    public class SiteContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=VerticalAit;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Widget> Widgets { get; set; }
        public DbSet<WidgetType> WidgetTypes { get; set; }
        public DbSet<WidgetSubType> WidgetSubTypes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WidgetType>().HasData(
                new WidgetType()
                {
                    Id = 1,
                    Type = "A"
                },
                new WidgetType()
                {
                    Id = 2,
                    Type = "B"
                },
                new WidgetType()
                {
                    Id = 3,
                    Type = "1"
                },
                new WidgetType()
                {
                    Id = 4,
                    Type = "2"
                }
                );

            modelBuilder.Entity<WidgetSubType>().HasData(
                new WidgetSubType()
                {
                    Id = 1,
                    SubType = "Apple",
                    WidgetTypeId = 1
                },
                new WidgetSubType()
                {
                    Id = 2,
                    SubType = "Aardvark",
                    WidgetTypeId = 1
                },
                new WidgetSubType()
                {
                    Id = 3,
                    SubType = "Astronaut",
                    WidgetTypeId = 1
                },
                new WidgetSubType()
                {
                    Id = 4,
                    SubType = "Bear",
                    WidgetTypeId = 2
                },
                new WidgetSubType()
                {
                    Id = 5,
                    SubType = "Bobcat",
                    WidgetTypeId = 2
                },
                new WidgetSubType()
                {
                    Id = 6,
                    SubType = "Beaver",
                    WidgetTypeId = 2
                },
                new WidgetSubType()
                {
                    Id = 7,
                    SubType = "First",
                    WidgetTypeId = 3
                },
                new WidgetSubType()
                {
                    Id = 8,
                    SubType = "One",
                    WidgetTypeId = 3
                },
                new WidgetSubType()
                {
                    Id = 9,
                    SubType = "Primary",
                    WidgetTypeId = 3
                },
                new WidgetSubType()
                {
                    Id = 10,
                    SubType = "Uno",
                    WidgetTypeId = 3
                },
                new WidgetSubType()
                {
                    Id = 11,
                    SubType = "Second",
                    WidgetTypeId = 4
                },
                new WidgetSubType()
                {
                    Id = 12,
                    SubType = "Two",
                    WidgetTypeId = 4
                },
                new WidgetSubType()
                {
                    Id = 13,
                    SubType = "Secondary",
                    WidgetTypeId = 4
                },
                new WidgetSubType()
                {
                    Id = 14,
                    SubType = "Dos",
                    WidgetTypeId = 4
                }
                );
        }
    }
}
