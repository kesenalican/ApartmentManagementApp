using ApartmentManagement.Entities.Concrete;
using ApartmentManagement.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Data.Abstract
{
    public interface IManagerRepository : IEntityRepository<Manager>
    {
       
    }
}
