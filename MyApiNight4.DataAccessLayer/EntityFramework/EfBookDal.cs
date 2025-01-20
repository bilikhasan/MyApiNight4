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
