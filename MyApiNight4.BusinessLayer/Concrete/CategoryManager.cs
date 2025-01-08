using Microsoft.EntityFrameworkCore.Design.Internal;
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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;           //CRUD işlemleri BusinessLayer ile haberlesebılsın dıye     

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }
        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
        }
        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }
        public void TInsert(Category entity)
        {
            _categoryDal.Insert(entity);
        }
        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
