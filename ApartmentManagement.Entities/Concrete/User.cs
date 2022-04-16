using ApartmentManagement.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entities.Concrete
{
    public class User: EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNo { get; set; }
        public string PhoneNumber { get; set; }
        public string CarPlate { get; set; }
        public int InvoiceElectricity{ get; set; }
        public int InvoiceWater { get; set; }
        public int InvoiceGas { get; set; }
        public int InvoiceInternet { get; set; }
        public string Dues { get; set; }
        public string Payment { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }

    }
}
