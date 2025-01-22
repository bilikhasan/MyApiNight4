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
    public class EfAuthorDal : GenericRepository<Author>, IAuthorDal
    {
        private readonly ApiContext _context;
        public EfAuthorDal(ApiContext context) : base(context)
        {
        }

        public List<Author> GetAllAuthors()
        {
            var context = new ApiContext();
            var values = context.Authors.ToList();
            return values;
        }

        public int GetAuthorCount()
        {
            var context = new ApiContext();
            var values = context.Authors.Count();
            return values;
        }
    }
}
