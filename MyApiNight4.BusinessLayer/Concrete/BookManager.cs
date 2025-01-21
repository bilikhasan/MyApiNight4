using MyApiNight4.BusinessLayer.Abstract;
using MyApiNight4.DataAccessLayer.Abstract;
using MyApiNight4.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight4.BusinessLayer.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;
        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void TDelete(int id)
        {
            _bookDal.Delete(id);
        }
        public List<Book> TGetAll()
        {
            return _bookDal.GetAll();
        }
        public Book TGetById(int id)
        {
            return _bookDal.GetById(id);
        }

        public List<Book> TGetPopularBooksAdventure()
        {
            return _bookDal.GetPopularBooksAdventure();
        }

        public List<Book> TGetPopularBooksBusiness()
        {
            return _bookDal.GetPopularBooksBusiness();
        }

        public List<Book> TGetPopularBooksFictional()
        {
            return _bookDal.GetPopularBooksFictional();
        }

        public List<Book> TGetPopularBooksRomantic()
        {
            return _bookDal.GetPopularBooksRomantic();
        }

        public List<Book> TGetPopularBooksTechnology()
        {
            return _bookDal.GetPopularBooksTechnology();
        }

        public Book TGetRandomBooks()
        {
            return _bookDal.GetRandomBooks();
        }

        public void TInsert(Book entity)
        {
            _bookDal.Insert(entity);
        }

        public void TUpdate(Book entity)
        {
            _bookDal.Update(entity);
        }
    }
}
