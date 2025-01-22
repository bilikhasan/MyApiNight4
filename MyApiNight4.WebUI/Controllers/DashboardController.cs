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
        public async Task<IActionResult> DashboardIndex()                
        {
            var clientAuthor = _httpClientFactory.CreateClient();                                              // Yazar Sayısı
            var authorResponseMessage = await clientAuthor.GetAsync("https://localhost:7039/api/Author/");
            if (authorResponseMessage.IsSuccessStatusCode)
            {
                var jsonDataAuthor = await authorResponseMessage.Content.ReadAsStringAsync();
                var valuesAuthor = JsonConvert.DeserializeObject<List<ResultAuthorDto>>(jsonDataAuthor);
                ViewBag.authorCount = valuesAuthor.Count;
            }



            var clientBook = _httpClientFactory.CreateClient();                                             //Kitap Sayısı
            var responseMessageBook = await clientBook.GetAsync("https://localhost:7039/api/Book");
            if(responseMessageBook.IsSuccessStatusCode)
            {
                var jsonDataBook = await responseMessageBook.Content.ReadAsStringAsync();
                var valuesBook = JsonConvert.DeserializeObject<List<ResultBookDto>>(jsonDataBook);
                ViewBag.bookCount = valuesBook.Count;
            }


            var clientCategory = _httpClientFactory.CreateClient();                                              //Kategori Ssyısı
            var responseMessageCategory = await clientCategory.GetAsync("https://localhost:7039/api/Category");
            if(responseMessageCategory.IsSuccessStatusCode)
            {
                var jsonDataCategory =await responseMessageCategory.Content.ReadAsStringAsync();
                var valuesCategory = JsonConvert.DeserializeObject<List<ResultCategoryDto>>(jsonDataCategory);
                ViewBag.categoryCount = valuesCategory.Count();
            }


            var clientFeature = _httpClientFactory.CreateClient();                                              //Öne Çıkan Sayısı
            var responseMessageFeature = await clientFeature.GetAsync("https://localhost:7039/api/Feature");
            if(responseMessageFeature.IsSuccessStatusCode)
            {
                var jsonDataFeature = await responseMessageFeature.Content.ReadAsStringAsync();
                var valuesFeature = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonDataFeature);
                ViewBag.featureCount = valuesFeature.Count();
            }




            return View();
        }
    }
}



