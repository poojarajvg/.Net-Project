using CodeSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeSample.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult OrderDetails()
        {

            return View();
        }
        [HttpGet]
        public JsonResult OrderList()
        {
            Repository.IOrderRepository orderDetails = Repository.OrderRepository.GetInstance();
            return Json(orderDetails.GetOrderList() , JsonRequestBehavior.AllowGet);
        }
    }
}