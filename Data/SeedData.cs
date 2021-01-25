using System;
using System.Collections.Generic;
using CityProv.Models;
using Microsoft.EntityFrameworkCore;

namespace CityProv.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                GetCities()
            );
            modelBuilder.Entity<Province>().HasData(
                GetProvinces()
            );
        }


        private static List<City> GetCities()
        {
            return new List<City>
            {
                new City() {
                    CityId = 1,
                    CityName = "Abbotsford",
                    Population = 141397,
                    ProvinceCode = "BC"
                },
                new City() {
                    CityId = 2,
                    CityName = "Langley",
                    Population = 25888,
                    ProvinceCode = "BC"
                },
                new City() {
                    CityId = 3,
                    CityName = "Surrey",
                    Population = 517887,
                    ProvinceCode = "BC"
                },
                new City() {
                    CityId = 4,
                    CityName = "Ottawa",
                    Population = 934243,
                    ProvinceCode = "ON"
                },
                new City() {
                    CityId = 5,
                    CityName = "St. Catharines",
                    Population = 133113,
                    ProvinceCode = "ON"
                },
                new City() {
                    CityId = 6,
                    CityName = "Waterloo",
                    Population = 104986,
                    ProvinceCode = "ON"
                },
                new City() {
                    CityId = 7,
                    CityName = "Calgary",
                    Population = 1239220,
                    ProvinceCode = "AB"
                },
                new City() {
                    CityId = 8,
                    CityName = "Edmonton",
                    Population = 972223,
                    ProvinceCode = "AB"
                },
                new City() {
                    CityId = 9,
                    CityName = "Red Deer",
                    Population = 100418,
                    ProvinceCode = "AB"
                }
            };
        }
        private static List<Province> GetProvinces()
        {
            return new List<Province>
            {
                new Province() {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia"
                },
                new Province() {
                    ProvinceCode = "ON",
                    ProvinceName = "Ontario"
                },
                new Province() {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta"
                }
            };
        }
    }
}