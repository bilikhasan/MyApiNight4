﻿using MyApiNight4.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight4.DataAccessLayer.Abstract
{
    public interface IBookDal :IGenericDal<Book>
    {
        Book GetRandomBooks();



        List<Book> GetPopularBooksBusiness();
        List<Book> GetPopularBooksAdventure();
        List<Book> GetPopularBooksRomantic();
        List<Book> GetPopularBooksTechnology();
        List<Book> GetPopularBooksFictional();

        List<Book> GetPopularBooksAllGenre();

        int GetBookCount();

    }
}
