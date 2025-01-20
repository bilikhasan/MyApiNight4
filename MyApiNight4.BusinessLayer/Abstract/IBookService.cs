using MyApiNight4.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight4.BusinessLayer.Abstract
{
    public interface IBookService :IGenericService<Book>
    {
        public Book TGetRandomBooks();

    }
}
