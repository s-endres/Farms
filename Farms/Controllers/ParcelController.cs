using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Farms.Data;
using Farms.Models;

namespace Farms.Controllers
{
    public class ParcelController : Controller
    {
        // GET: Parcel
        public ActionResult Index()
        {
            return View();
        }// GET: Parcel
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAllParcelByFarmId(int farmId)
        {
            return Json(ParcelData.ParcelList.Where(p => p.IdFarm == farmId), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetAllConditions()
        {
            return Json(ParcelData.ConditionList, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult AddParcel([Bind(Include = "Size,Description,IdFarm,Observations,ConditionIds")] Parcel parcel)
        {
            if (!string.IsNullOrEmpty(parcel.Size.ToString()) && !string.IsNullOrEmpty(parcel.Description) && parcel.Observations.Count > 0)
            {
                parcel.PlantIds = new List<int>();
                var last = ParcelData.ParcelList.Last();
                parcel.Id = last.Id + 1;
                ParcelData.ParcelList.Add(parcel);
                return Json(parcel, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }

    }
}