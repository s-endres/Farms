using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Farms.Models
{
    public class Farm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<int> ParcelIds { get; set; }
    }
}