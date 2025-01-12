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
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        private readonly ApiContext _context;

        public EfCategoryDal(ApiContext context) : base(context)
        {
            _context = context;
        }

        public int GetCategoryCount()
        {
            return _context.Categories.Count();
        }
    }
}
