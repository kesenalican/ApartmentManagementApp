using ApartmentManagement.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entities.Concrete
{
    public class Apartment : EntityBase, IEntity
    {
        public string Block { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Floor { get; set; }
        public int ApartmentNo { get; set; }
        //public User TenantId { get; set; }
    }
}
