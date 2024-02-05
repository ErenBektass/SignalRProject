﻿using Project.DAL.Abstract;
using Project.DAL.Context;
using Project.DAL.Repositories;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(MyContext context) : base(context)
        {
        }
    }
}
