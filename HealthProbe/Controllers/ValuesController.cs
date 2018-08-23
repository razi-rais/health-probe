using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HealthProbe.Controllers
{
    [Route("api/[controller]")]
    public class HealthCheckController : Controller
    {
        static volatile int counter = 0;
        [HttpGet]
        public IActionResult Get()
        {
            counter++;
            if (counter > 3)
            {
                return StatusCode(500);
    
            }
            return StatusCode(200);
        }
    }
}
