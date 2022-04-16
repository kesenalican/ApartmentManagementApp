using ApartmentManagement.Data.Abstract;
using ApartmentManagement.Data.Concrete.EntityFramework.Contexts;
using ApartmentManagement.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Data.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApartmentManagementContext _context;
        private EfApartmentRepository _apartmentRepository;
        private EfManagerRepository _managerRepository;
        private EfRoleRepository _roleRepository;
        private EfUserRepository _userRepository;

        public UnitOfWork(ApartmentManagementContext context)
        {
            _context = context;
        }

        public IApartmentRepository Apartments => _apartmentRepository ?? new EfApartmentRepository(_context);

        public IManagerRepository Manager => _managerRepository ?? new EfManagerRepository(_context);

        public IRoleRepository Roles => _roleRepository ?? new EfRoleRepository(_context);  

        public IUserRepository Users => _userRepository ?? new EfUserRepository(_context);

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();   
        }
         public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
