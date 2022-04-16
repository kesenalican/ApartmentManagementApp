using ApartmentManagement.Entities.Concrete;
using ApartmentManagement.Entities.DTOs;
using ApartmentManagement.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Services.Abstract
{
    public interface IUserService
    {
        Task<IDataResult<User>> Get(int userId);
        Task<IDataResult<IList<User>>> GetAll();
        Task<IDataResult<IList<User>>> GetAllByNoneDelete();
        Task<IResult> Add(UserAddDto userAddDto, string createdByName);
        Task<IResult> Update(UserUpdateDto userUpdateDto, string modifiedByName);
        Task<IResult> Delete(int userId, string modifiedByName);
        Task<IResult> HardDelete(int userId);
    }
}
