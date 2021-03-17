using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AvengersController : Controller
    {
        [HttpGet]
        public string Strongest()
        {
            return "Iron Man!";
        }
    }
}