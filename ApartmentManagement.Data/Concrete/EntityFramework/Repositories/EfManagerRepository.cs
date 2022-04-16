﻿using ApartmentManagement.Data.Abstract;
using ApartmentManagement.Entities.Concrete;
using ApartmentManagement.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Data.Concrete.EntityFramework.Repositories
{
    public class EfManagerRepository : EfEntityRepositoryBase<Manager>, IManagerRepository
    {
        public EfManagerRepository(DbContext context) : base(context)
        {
        }
    }
}
