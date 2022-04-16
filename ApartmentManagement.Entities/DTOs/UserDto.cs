using ApartmentManagement.Entities.Concrete;
using ApartmentManagement.Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Entities.DTOs
{
    public class UserDto
    {
        public User User { get; set; }
        public ResultStatus ResultStatus { get; set; }
    }
}
