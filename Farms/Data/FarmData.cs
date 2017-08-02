﻿using Farms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Farms.Data
{
    public static class FarmData
    {
        public static List<Farm> FarmList = new List<Farm>()
        {
            new Farm()
            {
                Id = 1,
                Name = "First farm",
                Description = "Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.",
                ParcelIds = new List<int>(){1,2,3}
            },

            new Farm()
            {
                Id = 2,
                Name = "Second farm",
                Description = "Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi.",
                ParcelIds = new List<int>(){4,5}
            },
            new Farm()
            {
                Id = 3,
                Name = "Third farm",
                Description = "Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi."
            }
        };
    }
}