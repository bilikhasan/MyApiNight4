using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApiNight4.BusinessLayer.Abstract;
using MyApiNight4.EntityLayer.Concrete;

namespace MyApiNight4.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult BookList()
        {
            var values = _bookService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            _bookService.TInsert(book);
            return Ok("Ekleme Başarılı");
        }

        [HttpDelete]
        public IActionResult DeleteBook(int id)
        {
            _bookService.TDelete(id);
            return Ok("Silme Başarılı");
        }

        [HttpPut]
        public IActionResult UpdateBook(Book book)
        {
            _bookService.TUpdate(book);
            return Ok("Güncelleme Başarılı");
        }

        [HttpGet("GetBook")]
        public IActionResult GetBook(int id)
        {
            var values = _bookService.TGetById(id);
            return Ok(values);
        }

        [HttpGet("GetRandomBook")]                                            //APİ KATMANI
        public IActionResult GetRandomBook()
        {
            var book = _bookService.TGetRandomBooks();
            if (book == null)
            {
                return NotFound("Kitap bulunamadı.");
            }
            return Ok(book);
        }

        [HttpGet("GetPopularBooksBusiness")]
        public IActionResult GetPopularBooksBusiness()
        {
            var values = _bookService.TGetPopularBooksBusiness();
            return Ok(values);
        }

        [HttpGet("GetPopularBooksAdventure")]
        public IActionResult GetPopularBooksAdventure()
        {
            var values = _bookService.TGetPopularBooksAdventure();
            return Ok(values);
        }

        [HttpGet("GetPopularBooksRomantic")]
        public IActionResult GetPopularBooksRomantic()
        {
            var values = _bookService.TGetPopularBooksRomantic();
            return Ok(values);
        }

        [HttpGet("GetPopularBooksTechnology")]
        public IActionResult GetPopularBooksTechnology()
        {
            var values = _bookService.TGetPopularBooksTechnology();
            return Ok(values);
        }

        [HttpGet("GetPopularBooksFictional")]
        public IActionResult GetPopularBooksFictional()
        {
            var values = _bookService.TGetPopularBooksFictional();
            return Ok(values);
        }

        [HttpGet("GetPopularBooksAllGenre")]
        public IActionResult GetPopularBooksAllGenre()
        {
            var values = _bookService.TGetPopularBooksAllGenre();
            return Ok(values);
        }

        [HttpGet("GetBookCount")]
        public IActionResult GetBookCount()
        {
            var values = _bookService.TGetBookCount();
            return Ok(values);
        }
    }
}
