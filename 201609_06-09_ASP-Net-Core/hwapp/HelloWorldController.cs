using System;
using Microsoft.AspNetCore.Mvc;

namespace HWApp
{
    public class HelloWorldController : Controller
    {
        [HttpGet("helloworld")]
        public ActionResult HelloWorldMvc()
        {
            ViewBag.Message = "Hello World from MVC!!";
            ViewBag.Time = DateTime.Now;

            return View("helloworld");
            //return View("~/helloworld.cshtml");           
        }

        [HttpGet("api/helloworld")]
        public object HelloWorld()
        {
            return new
            {
                message = "Hello World!!",
                time = DateTime.Now
            };
        }

        [HttpGet("api/halodunia")]
        public object HaloDunia()
        {
            return new
            {
                message = "Halo Dunia!",
                time = DateTime.Now
            };
        }
    }
}