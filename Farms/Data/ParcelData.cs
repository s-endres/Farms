using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Farms.Models;

namespace Farms.Data
{
    public static class ParcelData
    {
        public static List<Parcel> ParcelList = new List<Parcel>()
        {
            new Parcel()
            {
                Id = 1,
                Size = 15.98,
                Description = "asdasdasdasdasdasdasd",
                IdFarm = 1,
                PlantIds = new List<int>(){1,2},
                ConditionIds = new List<int>(){3,4}
            },
            new Parcel()
            {
                Id = 2,
                Size = 176.98,
                Description = "qwe qwe qweqw eqwe qwe",
                IdFarm = 1,
                PlantIds = new List<int>(){1,2},
                ConditionIds = new List<int>(){3,4}
            }
        };

        public static List<Condition> ConditionList = new List<Condition>()
        {
            new Condition()
            {
                Id = 1,
                Name = "Rainy"
            },
            new Condition()
            {
                Id = 2,
                Name = "Dry"
            },
            new Condition()
            {
                Id = 3,
                Name = "Very dry"
            }
        };



    }
}