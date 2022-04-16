using ApartmentManagement.Entities.Concrete;
using ApartmentManagement.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entities.DTOs
{
    public class ApartmentListDto :DtoGetBase
    {
        public IList<Apartment> Apartments { get; set; }
    }
}
