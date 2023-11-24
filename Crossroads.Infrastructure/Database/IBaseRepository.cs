﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crossroads.Infrastructure.Database
{
    internal interface IBaseRepository<TEntity>
    {
        TEntity GetById(long id);
        List<TEntity> GetList();
        //TEntity Update(TEntity entity);
        //TEntity Delete(long id);
        //TEntity Add(TEntity entity);

    }
}
