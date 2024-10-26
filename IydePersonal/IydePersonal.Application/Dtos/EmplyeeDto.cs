using IydePersonal.Domain.Entities;

namespace IydePersonal.Application.Dtos
{
    public class EmplyeeDto
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public WorkPosition WorkPosition { get; set; }
        
        public bool Active { get; set; }
        public int FixSalary { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime FinishWork { get; set; }
        public int UserId { get; set; }

        public int StoreId { get; set; }

    }
}
