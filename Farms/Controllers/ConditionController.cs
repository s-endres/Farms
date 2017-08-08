using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Farms.Data;

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