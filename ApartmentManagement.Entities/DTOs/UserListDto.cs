using ApartmentManagement.Entities.Concrete;
using ApartmentManagement.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace ApartmentManagement.Entities.DTOs
{
    public class UserListDto : DtoGetBase
    {
        public IList<User> Users { get; set; }

    }
}
