﻿using Microsoft.AspNetCore.Mvc;
using MyApiNight4.WebUI.Dtos;
using Newtonsoft.Json;
using System.Text;

namespace MyApiNight4.WebUI.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AuthorsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> AuthorList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7039/api/Author");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAuthorDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public IActionResult CreateAuthor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorDto createAuthorDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createAuthorDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7039/api/Author", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AuthorList");
            }
            return View();
        }

        public async Task<IActionResult> DeleteAuthor(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync("https://localhost:7039/api/Author?id=" + id);
            if(responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AuthorList");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAuthor (int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7039/api/Author/GetAuthor?id=" + id);
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateAuthorDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorDto updateAuthorDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateAuthorDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7039/api/Author/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("AuthorList");
            }
            return View();
        }
    }
}