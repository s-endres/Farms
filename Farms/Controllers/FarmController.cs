using Farms.Data;
using Farms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Farms.Controllers
{
    public class FarmController : Controller
    {
        // GET: Farm
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AddFarm([Bind(Include = "Name,Description")] Farm farm)
        {
            if(!string.IsNullOrEmpty(farm.Name) && !string.IsNullOrEmpty(farm.Description))
            {
                farm.ParcelIds = new List<int>();
                var lastFarm = FarmData.FarmList.Last();
                farm.Id = lastFarm.Id+1;
                FarmData.FarmList.Add(farm);
                return Json(farm, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }

        [HttpDelete]
        public JsonResult RemoveFarm(int farmId)
        {
            try
            {
                var farm = FarmData.FarmList.Where(f => f.Id == farmId).FirstOrDefault();
                FarmData.FarmList.Remove(farm);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public JsonResult getFarm(int? farmId)
        {
            if (farmId != null)
            {
                var farm = FarmData.FarmList.Where(s => s.Id == farmId).FirstOrDefault();
                return Json(farm, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }
        
        [HttpPut]
        public JsonResult UpdateFarm([Bind(Include = "Id,Name,Description")] Farm farm)
        {
            if (farm.Id != 0)
            {
                var foundFarm = FarmData.FarmList.Where(s => s.Id == farm.Id).FirstOrDefault();
                foundFarm.Name = farm.Name;
                foundFarm.Description = farm.Description;
                return Json(foundFarm, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetAllFarms()
        {
            return Json(FarmData.FarmList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetFarmsById(int farmId)
        {
            return Json(FarmData.FarmList.Where(f => f.Id == farmId).FirstOrDefault(), JsonRequestBehavior.AllowGet);
        }


    }
}