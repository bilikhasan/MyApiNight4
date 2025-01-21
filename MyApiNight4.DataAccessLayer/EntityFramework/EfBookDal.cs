using MyApiNight4.DataAccessLayer.Abstract;
using MyApiNight4.DataAccessLayer.Context;
using MyApiNight4.DataAccessLayer.Repositories;
using MyApiNight4.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight4.DataAccessLayer.EntityFramework
{
    public class EfBookDal : GenericRepository<Book>, IBookDal
    {
        private readonly ApiContext _context;

        public EfBookDal(ApiContext context) : base(context)
        {
            _context = context;
        }

        public List<Book> GetPopularBooksAdventure()
        {
            var context = new ApiContext();
            var values = context.Books.Where(x => x.Category.CategoryName == "Macera - Aksiyon").ToList();
            return values;
        }

        public List<Book> GetPopularBooksAllGenre()
        {
            var context = new ApiContext();
            var values = context.Books.ToList();
            return values;
        }

        public List<Book> GetPopularBooksBusiness()
        {
            var context = new ApiContext();
            var values = context.Books.Where(x => x.Category.CategoryName == "İş Dünyası").ToList();
            return values;
        }

        public List<Book> GetPopularBooksFictional()
        {
            var context = new ApiContext();
            var values = context.Books.Where(x => x.Category.CategoryName == "Bilim-Kurgu").ToList();
            return values;
        }

        public List<Book> GetPopularBooksRomantic()
        {
            var context = new ApiContext();
            var values = context.Books.Where(x => x.Category.CategoryName == "Romantik - Aşk").ToList();
            return values;
        }

        public List<Book> GetPopularBooksTechnology()
        {
            var context = new ApiContext();
            var values = context.Books.Where(x => x.Category.CategoryName == "Teknoloji - Bilim").ToList();
            return values;
        }

        public Book GetRandomBooks()
        {
            int count = _context.Set<Book>().Count();
            Random random = new Random();
            int randomIndex = new Random().Next(1, count);
            var values = _context.Set<Book>()
                .Skip(randomIndex)
                .Take(1)
                .FirstOrDefault();
            return values;
        }
    }
}
