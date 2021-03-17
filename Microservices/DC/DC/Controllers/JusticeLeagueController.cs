using Microsoft.AspNetCore.Mvc;

namespace DC.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class JusticeLeagueController : Controller
    {
        [HttpGet]
        public string Strongest()
        {
            return "Batman!";
        }
    }
}