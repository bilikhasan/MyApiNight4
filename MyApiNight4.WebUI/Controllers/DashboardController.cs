using Microsoft.AspNetCore.Mvc;
using MyApiNight4.WebUI.Dtos;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace MyApiNight4.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public DashboardController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IActionResult> DashboardIndex()                // yazar sayısı
        {
            var client = _httpClientFactory.CreateClient();
            var authorResponse = await client.GetAsync("https://localhost:7039/api/Author/");
            if (authorResponse.IsSuccessStatusCode)
            {
                var jsonAuthorData = await authorResponse.Content.ReadAsStringAsync();
                var authorValues = JsonConvert.DeserializeObject<List<ResultAuthorDto>>(jsonAuthorData);
                ViewBag.Authors = authorValues.Count;
            }
            return View();
        }
    }
}



