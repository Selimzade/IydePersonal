using IydePersonal.Application.Dtos.Store;
using IydePersonal.Application.Dtos.User;
using IydePersonal.Domain.Entities;
using IydePersonal.Domain.Entities.Edentity;

namespace IydePersonal.Application.Dtos.Employee
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        //public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public WorkPosition WorkPosition { get; set; }
        public bool IsActive { get; set; }
        public int FixSalary { get; set; }
        public string Adress { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime FinishWork { get; set; }
        public int UserId { get; set; }
        public AppUser appUser  { get; set; }

    }
}
