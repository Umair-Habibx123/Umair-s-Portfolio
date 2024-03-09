using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using WebApplication1.Models;
using System.Xml.Linq;

namespace WebApplication1.Controllers
{

    /*public class About : Controller
    {
        //attribute based routing
        *//*[HttpGet]
        [Route("/AboutUs/")]*//*
                             //GET Request: /controller/
       public IActionResult Index()
        {
            // conventional routing > localhost:7173/AboutUs/Index
            string html = "<h1> About US </h1>";
            return Content(html, "text/html");
        }

    }*/

    public class HomeController : Controller  //controller name
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //action name/method ... home/Index
        {
            return View();
        }
        [HttpGet]
        [Route("/about/")]
        public IActionResult about()
        {
            return View();
        }
        //attribute based routing
        [HttpGet]
        [Route("/skills/")]
        public IActionResult skills() //action name/method ... home/Index
        {
            return View();
        }
        [HttpGet]
        [Route("/work/")]
        public IActionResult work()
        {
            return View();
        }

        [HttpGet]
        [Route("/Contact_Me/")]
        public IActionResult Contact_Me()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
