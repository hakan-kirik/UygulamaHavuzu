using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UygulamaHavuzu2.Model;

namespace UygulamaHavuzu2.Controllers
{
    public class RandomQuotesController : Controller
    {
      
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var res = await client.GetAsync($"http://api.quotable.io/random");
            if (res.StatusCode != System.Net.HttpStatusCode.OK)
            {
                return NotFound();

            }
            var json = await res.Content.ReadAsStringAsync();
            var randomQuote = RandomQuotes.FromJson(json);

            return View(randomQuote);
        }
    }
}
