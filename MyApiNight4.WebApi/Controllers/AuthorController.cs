using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApiNight4.BusinessLayer.Abstract;
using MyApiNight4.EntityLayer.Concrete;

namespace MyApiNight4.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IActionResult AuthorList()
        {
            var values = _authorService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAuthor(Author author)
        {
            _authorService.TInsert(author);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteAuthor(int id)
        {
            _authorService.TDelete(id);
            return Ok("Silme Başarılı");
        }

        [HttpPut]
        public IActionResult UpdateAuthor(Author author)
        {
            _authorService.TUpdate(author);
            return Ok("Güncelleme Başarılı");
        }
        [HttpGet("GetAuthor")]
        public IActionResult GetAuthor(int id)
        {
            var values = _authorService.TGetById(id);
            return Ok(values);
        }
    }
}
