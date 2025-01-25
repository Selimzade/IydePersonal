using IydePersonal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Dtos.Employee
{
    public class GetAllEmployeeforUserDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        //public string LastName { get; set; }
        public Gender Gender { get; set; }

        public bool IsActive { get; set; }
        public DateTime DateOfBirth { get; set; }
        public WorkPosition WorkPosition { get; set; }
        public DateTime StartWork { get; set; }
    }
}
