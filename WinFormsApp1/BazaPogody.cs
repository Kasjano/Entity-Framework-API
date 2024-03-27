using System.Text;
using System.Threading.Tasks;
//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
[assembly: InternalsVisibleTo("WinFormsApp1")]

namespace API
{
    internal class BazaPogody : DbContext
    {
        public DbSet<WeatherData> Weather_Datas { get; set; }
        public BazaPogody()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=C:\Users\Admin\Desktop\programy\.NET\lab2_kardas_sr19\WinFormsApp1\Pogoda.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherData>().HasData(
            new WeatherData() { Id = 1, City = "Wrocław", Temperature = "17", Wind_speed = "7.8", Description = "bezchmurnie" },
            new WeatherData() { Id = 2, City = "Warszawa", Temperature = "15", Wind_speed = "9.5", Description = "bezchmurnie" }
            );
        }
    }
}
