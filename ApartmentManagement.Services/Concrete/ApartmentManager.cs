using ApartmentManagement.Data.Abstract;
using ApartmentManagement.Entities.Concrete;
using ApartmentManagement.Entities.DTOs;
using ApartmentManagement.Services.Abstract;
using ApartmentManagement.Shared.Utilities.Results.Abstract;
using ApartmentManagement.Shared.Utilities.Results.ComplexTypes;
using ApartmentManagement.Shared.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Services.Concrete
{
    
    public class ApartmentManager : IApartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ApartmentManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> Add(ApartmentAddDto apartmentAddDto, string createdByName)
        {
            await _unitOfWork.Apartments.AddAsync(new Apartment
            {
                ApartmentNo = apartmentAddDto.ApartmentNo,
                Block = apartmentAddDto.Block,
                Floor = apartmentAddDto.Floor,
                Status = apartmentAddDto.Status,
                Type = apartmentAddDto.Type,
                CreatedByName = createdByName,
                CreatedDate = DateTime.Now,
                ModifiedByName = createdByName,
                ModifiedDate = DateTime.Now,
                IsDeleted = false,
                IsActive = apartmentAddDto.IsActive
            }).ContinueWith(t => _unitOfWork.SaveAsync()) ;
            //await _unitOfWork.SaveAsync();
            return new Result(ResultStatus.Success, $"{apartmentAddDto.ApartmentNo} adlı daire eklenmiştir.");
        }

        public async Task<IResult> Delete(int apartmentId, string modifiedByName)
        {
            var apartment = await _unitOfWork.Apartments.GetAsync(c => c.Id == apartmentId);
            if (apartment != null)
            {
                apartment.IsDeleted = true;
                apartment.ModifiedByName = modifiedByName;
                apartment.ModifiedDate = DateTime.Now;
                await _unitOfWork.Apartments.UpdateAsync(apartment).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{apartment.ApartmentNo} nolu daire başarılı şekilde silinmiştir.");
            }
            return new DataResult<Apartment>(ResultStatus.Error, "Böyle bir daire bulunamadı", null);
        }

        public async Task<IDataResult<Apartment>> Get(int apartmentId)
        {
            var apartment = await _unitOfWork.Apartments.GetAsync(c =>c.Id == apartmentId);
            if (apartment != null)
            {
                return new DataResult<Apartment>(ResultStatus.Success, apartment);
            }
            return new DataResult<Apartment>(ResultStatus.Error, "Böyle bir daire bulunamadı", null); 
        }

        public async Task<IDataResult<IList<Apartment>>> GetAll()
        {
            var apartments = await _unitOfWork.Apartments.GetAllAsync();
            if (apartments.Count > -1)
            {
                return new DataResult<IList<Apartment>>(ResultStatus.Success, apartments);
            }
            return new DataResult<IList<Apartment>>(ResultStatus.Error, "Hiçbir daire bulunamadı", null);

        }

        public async Task<IDataResult<IList<Apartment>>> GetAllByNoneDelete()
        {
            var apartments = await _unitOfWork.Apartments.GetAllAsync(c => !c.IsDeleted);
            if (apartments.Count>-1)
            {
                return new DataResult<IList<Apartment>>(ResultStatus.Success, apartments);
            }
            return new DataResult<IList<Apartment>>(ResultStatus.Error, "Hiçbir daire bulunamadı", null);
        }

        public async Task<IResult> HardDelete(int apartmentId)
        {
            var apartment = await _unitOfWork.Apartments.GetAsync(c => c.Id == apartmentId);
            if (apartment != null)
            {
                await _unitOfWork.Apartments.DeleteAsnyc(apartment).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{apartment.ApartmentNo} nolu daire başarılı şekilde veritabanından silinmiştir.");
            }
            return new DataResult<Apartment>(ResultStatus.Error, "Böyle bir daire bulunamadı", null);
        }

        public async Task<IResult> Update(ApartmentUpdateDto apartmentUpdateDto, string modifiedByName)
        {
            var apartment = await _unitOfWork.Apartments.GetAsync(c => c.Id == apartmentUpdateDto.Id);
            if (apartment != null)
            {
                apartment.ApartmentNo = apartmentUpdateDto.ApartmentNo;
                apartment.Block = apartmentUpdateDto.Block;
                apartment.Floor = apartmentUpdateDto.Floor;
                apartment.Status = apartmentUpdateDto.Status;
                apartment.Type = apartmentUpdateDto.Type;
                await _unitOfWork.Apartments.UpdateAsync(apartment).ContinueWith(t => _unitOfWork.SaveAsync());
                return new Result(ResultStatus.Success, $"{apartmentUpdateDto.ApartmentNo} nolu daire başarılı şekilde güncellenmiştir.");
            }
            return new DataResult<Apartment>(ResultStatus.Error, "Böyle bir daire bulunamadı", null);
        }
    }
}
