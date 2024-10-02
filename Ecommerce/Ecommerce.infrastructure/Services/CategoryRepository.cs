﻿using Ecommerce.application.Repository;
using Ecommerce.infrastructure.Presistance;
using ECOMMERCE.DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.infrastructure.Services
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DBContextApplication context) : base(context)
        {
        }
    }
}
