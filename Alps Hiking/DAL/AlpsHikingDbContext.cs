﻿using Alps_Hiking.Entities;
using Microsoft.EntityFrameworkCore;

namespace Alps_Hiking.DAL
{
	public class AlpsHikingDbContext :DbContext
	{
		public AlpsHikingDbContext(DbContextOptions<AlpsHikingDbContext> options) : base(options)
		{

		}

		public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Destiantion> Destiantions { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourImage> TourImages { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Itinerary> Itineraries { get; set; }
        public DbSet<PassengerCount>PassengerCounts { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TourDate> TourDates { get; set; }
        public DbSet<Partner> Partners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Setting>()
				.HasIndex(s => s.Key)
				.IsUnique();
		}
	}
}
