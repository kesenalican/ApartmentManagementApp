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
    public interface IApartmentService
    {
        Task<IDataResult<Apartment>> Get(int apartmentId);
        Task<IDataResult<IList<Apartment>>> GetAll();
        Task<IDataResult<IList<Apartment>>> GetAllByNoneDelete();
        Task<IResult> Add(ApartmentAddDto apartmentAddDto, string createdByName);
        Task<IResult> Update(ApartmentUpdateDto apartmentUpdateDto, string modifiedByName);
        Task<IResult> Delete(int apartmentId, string modifiedByName);
        Task<IResult> HardDelete(int apartmentId);
    }
}
