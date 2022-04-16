using ApartmentManagement.Entities.Concrete;
using ApartmentManagement.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Data.Abstract
{
    public interface IApartmentRepository:IEntityRepository<Apartment>
    {
        
    }
}
