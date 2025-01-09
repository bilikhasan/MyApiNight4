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
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(ApiContext context) : base(context)
        {
        }

        public int GetProductCount()
        {
            var context = new ApiContext();
            int value = context.Products.Count();
            return value;
        }
    }
}
