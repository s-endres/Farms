using Farms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Farms.Controllers
{
    public class PlantTypeController : Controller
    {
        // GET: PlantType
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAllPlantTypes()
        {
            return Json(PlantData.PlantTypeList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetTypePlantById(int plantTypeId)
        {
            return Json(PlantData.PlantTypeList.Where(p => p.Id == plantTypeId).FirstOrDefault(), JsonRequestBehavior.AllowGet);
        }
    }
}