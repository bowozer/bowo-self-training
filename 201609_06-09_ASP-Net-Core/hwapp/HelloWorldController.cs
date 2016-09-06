using System;
using Microsoft.AspNetCore.Mvc;

namespace HWApp
{
    public class HelloWorldController
    {
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