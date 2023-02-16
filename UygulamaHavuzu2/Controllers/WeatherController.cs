using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UygulamaHavuzu2.Models;
using System.Text.Json;

namespace UygulamaHavuzu2.Controllers
{
    public class WeatherController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();

            IList<WeatherModels> ApiResults = new List<WeatherModels>();

            IList<string> Apicities = new List<string>();
            Apicities.Add("sakarya");
            Apicities.Add("istanbul");
            Apicities.Add("ankara");
            Apicities.Add("bursa");


            foreach (var apiCity in Apicities)
            {
                var res = await client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={apiCity}&appid=87ee4861727771a1ce31609f31e5be98&units=metric&lang=tr");
                var json = await res.Content.ReadAsStringAsync();
                var timeEdit = WeatherModels.FromJson(json);
                DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                origin = origin.AddSeconds(timeEdit.Sys.Sunset + timeEdit.Timezone);
                timeEdit.Sys.sunsetTime = origin.ToString("HH:mm");

                ApiResults.Add(timeEdit);
            }



            return View(ApiResults);
        }
        public async Task<IActionResult> SearchWeather(string value)
        {
            var client = new HttpClient();
            var res = await client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={value}&appid=87ee4861727771a1ce31609f31e5be98&units=metric&lang=tr");
            if (res.StatusCode == System.Net.HttpStatusCode.OK)
            {

                var json = await res.Content.ReadAsStringAsync();
                var timeEdit = WeatherModels.FromJson(json);
                DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                origin = origin.AddSeconds(timeEdit.Sys.Sunset + timeEdit.Timezone);
                timeEdit.Sys.sunsetTime = origin.ToString("HH:mm");

                return View("_weatherPartial", timeEdit);

            }
            return Ok();
        }
    }
}
