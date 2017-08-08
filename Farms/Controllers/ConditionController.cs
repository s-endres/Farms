using Farms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Farms.Controllers
{
    public class ConditionController : Controller
    {
        // GET: Condition
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAllConditions()
        {
            return Json(ParcelData.ConditionList, JsonRequestBehavior.AllowGet);
        }
    }
}