using ApartmentManagement.Entities.Concrete;
using ApartmentManagement.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Services.Abstract
{
    public interface IManagerService
    {
        Task<IDataResult<Manager>> Get(int apartmentId);
        Task<IDataResult<IList<Manager>>> GetAll();
        Task<IDataResult<IList<Manager>>> GetAllByNoneDelete();
       // Task<IResult> Add(ManagerAddDto apartmentAddDto, string createdByName);
        //Task<IResult> Update(ManagerUpdateDto apartmentUpdateDto, string modifiedByName);
        Task<IResult> Delete(int apartmentId, string modifiedByName);
        Task<IResult> HardDelete(int apartmentId);
    }
}
