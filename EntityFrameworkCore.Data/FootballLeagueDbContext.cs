using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Text;


namespace EntityFrameworkCore.Data
{
    internal class FootballLeagueDbContext : DbContext

    {
        //public FootballLeagueDbContext()
        //{
        //    var folder = Environment.SpecialFolder.LocalApplicationData;
        //    var path = Environment.GetFolderPath(folder);
        //    DbPath = Path.Combine
        //}
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //using sql server
            //optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");

            optionsBuilder.UseSqlite($"Data Source = FootballLeage_EfCore.db")
                //.LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    TeamId = 1,
                    TeamName = "eagles",
                    CreatedDate = DateTimeOffset.UtcNow.DateTime
                }
                new Team
                {
                    TeamId = 2,
                    TeamName = "Argentina",
                    CreatedDate = DateTimeOffset.UtcNow.DateTime
                }
                new Team
                {
                    TeamId = 3,
                    TeamName = "Spain",
                    CreatedDate = DateTimeOffset.UtcNow.DateTime
                }
                );
        }
    }
}
