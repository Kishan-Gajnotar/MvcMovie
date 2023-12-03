using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*public string Welcome()
        {
            return "This is the Welcome action method...";
        }*/
        public IActionResult Welcome(string name = "kishan", int numTimes = 1) // HelloWorld/Welcome?name=Rick&numtimes=4
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
