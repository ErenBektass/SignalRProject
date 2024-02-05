﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetByID(int id);
        List<T> GetListAll();
    }
}
