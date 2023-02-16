using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UygulamaHavuzu2.Models;

namespace UygulamaHavuzu2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            List<CardContent> model = new List<CardContent>()
            {
                new CardContent(){url="/Todo",image=@"/content/img/todo_1_250x420.png",title="Todo App"},
                new CardContent(){url="/BmiCalculator",image=@"\content\img\bmi_250x420.jpg",title="BMI Calculator App"},
                new CardContent(){url="/Weather",image=@"\content\img\weather_250x420.jpg",title="Weather App"},
                new CardContent(){url="/RandomQuotes",image=@"\content\img\quote_1_250x420.jpg",title="Quote App"}
            };
            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
