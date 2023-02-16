using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using UygulamaHavuzu2.Models;

namespace UygulamaHavuzu2.Controllers
{
    public class BmiCalculatorController : Controller
    {   
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculateViewModel md)
        {
           var HeightMt= md.Height / 100;//cm-meter
            md.Result = md.Weight / (HeightMt * HeightMt);

            if (md.Result < 18.5)
            {
                md.YourResult = "Under Weight";
            }
            else if (md.Result >= 18.5 && md.Result < 25)
            {
                md.YourResult = "Normal";
            }
            else if (md.Result >= 25 && md.Result < 30)
            {
                md.YourResult = "Over weight";
            }else if (md.Result >= 30)
            {
                md.YourResult = "Obese";
            }
           
            var jsondata = JsonConvert.SerializeObject(md);
            return Json(jsondata);
        }

    }
}
