﻿using Microsoft.AspNetCore.Mvc;
using MyApiNight4.WebUI.Dtos;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace MyApiNight4.WebUI.ViewComponents
{
    public class _DefaultGetPopularBooksAdventure : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DefaultGetPopularBooksAdventure(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7039/api/Book/GetPopularBooksAdventure");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBookDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
