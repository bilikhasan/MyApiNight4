﻿using MyApiNight4.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight4.DataAccessLayer.Abstract
{
    public interface IFeatureDal :IGenericDal<Feature>
    {
        List<Feature> GetLastFourBooks();


        int GetFeatureCount();
    }
}
