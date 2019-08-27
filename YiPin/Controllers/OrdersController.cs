using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
namespace YiPin.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ExtractArea()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ExtractArea(ExtractAreaModel model)
        {
            var tmpFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tmp");
            if (!Directory.Exists(tmpFolder))
                Directory.CreateDirectory(tmpFolder);
            var orderFilePath = Path.Combine(tmpFolder, Guid.NewGuid().ToString() + ".xlsx");
            if (model.OrderFile != null)
                model.OrderFile.SaveAs(orderFilePath);







            return Json(new { Name = "test" });
        }

    }


    public class ExtractAreaModel
    {
        public string Area { get; set; }
        public HttpPostedFileBase OrderFile { get; set; }
    }
}