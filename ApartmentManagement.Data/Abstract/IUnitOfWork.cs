using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Data.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IApartmentRepository Apartments { get; } //_unitOfWork.Apartments
        IManagerRepository Manager { get; } 
        IRoleRepository Roles { get; }  
        IUserRepository Users { get; } // _unitOfWork.Users.AddAsync(user);
        Task<int> SaveAsync();
    }
}
