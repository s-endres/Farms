﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Farms.Models;

namespace Farms.Data
{
    public static class PlantData
    {
        public static List<Plant> PlantList = new List<Plant>()
        {
            new Plant()
            {
                Id = 1,
                Name = "Trixy",
                Description = "Ut wisi enim ad minim veniam, quis nostrud exerci tation u",
                PlantedDate = "2018-06-10",
                IdParcel = 1,
                PlantType = 1,
            },
            new Plant()
            {
                Id = 2,
                Name = "Bella",
                Description = "Ut wisi enim ad minim veniam, quis nostrud exerci tation u",
                PlantedDate = "2017-04-10",
                IdParcel = 1,
                PlantType = 2,
            }
        };

        public static List<PlantType> PlantTypeList = new List<PlantType>()
        {
            new PlantType()
            {
                Id = 1,
                Name = "Coffee"
            },
            new PlantType()
            {
                Id = 2,
                Name = "Papaya"
            },
            new PlantType()
            {
                Id = 3,
                Name = "Mango"
            },
            new PlantType()
            {
                Id = 4,
                Name = "Banana"
            }
        };




    }
}