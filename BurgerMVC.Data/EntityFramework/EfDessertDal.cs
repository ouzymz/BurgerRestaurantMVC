﻿using BurgerMVC.DataLayer.Abstract;
using BurgerMVC.DataLayer.Repository;
using BurgerMVC.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVC.DataLayer.EntityFramework
{
    public class EfDessertDal : GenericRepository<Dessert>,IDessertDal
    {
    }
}
