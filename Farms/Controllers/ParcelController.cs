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
        }// GET: Parcel
        public ActionResult Edit()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAllParcelByFarmId(int farmId)
        {
            return Json(ParcelData.ParcelList.Where(p => p.IdFarm == farmId), JsonRequestBehavior.AllowGet);
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

        [HttpGet]
        public JsonResult GetParcel(int? parcelId)
        {
            if (parcelId != null)
            {
                var parcel = ParcelData.ParcelList.Where(s => s.Id == parcelId).FirstOrDefault();
                return Json(parcel, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }

        [HttpPut]
        public JsonResult UpdateParcel([Bind(Include = "Id,Size,Description,IdFarm,Observations,ConditionIds")] Parcel parcel)
        {
            if (!string.IsNullOrEmpty(parcel.Size.ToString()) && !string.IsNullOrEmpty(parcel.Description) && parcel.Observations.Count > 0)
            {
                var foundParcel = ParcelData.ParcelList.Where(s => s.Id == parcel.Id).FirstOrDefault();
                foundParcel.Size = parcel.Size;
                foundParcel.Description = parcel.Description;
                foundParcel.Observations = parcel.Observations;
                foundParcel.ConditionIds = parcel.ConditionIds;
                return Json(foundParcel, JsonRequestBehavior.AllowGet);
            }
            return Json(false, JsonRequestBehavior.AllowGet);
        }

        [HttpDelete]
        public JsonResult RemoveParcel(int parcelId)
        {
            try
            {
                var parcel = ParcelData.ParcelList.Where(f => f.Id == parcelId).FirstOrDefault();
                ParcelData.ParcelList.Remove(parcel);
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

    }
}