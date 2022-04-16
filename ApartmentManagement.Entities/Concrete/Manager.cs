using ApartmentManagement.Shared.Entities.Abstract;


namespace ApartmentManagement.Entities.Concrete
{
    public class Manager:EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
