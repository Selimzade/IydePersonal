﻿using IydePersonal.Application.Dtos.Store;
using IydePersonal.Application.Dtos.User;
using IydePersonal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Dtos.Employee
{
    public class EmployeeUpdateDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
       // public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public WorkPosition WorkPosition { get; set; }
        public int FixSalary { get; set; }
        public string Address { get; set; }
       // public int StoryId { get; set; }
        //  public bool IsActive { get; set; } 
        public DateTime StartWork { get; set; }
        //public IList<StoreDto> stores { get; set; }
        public int UserId { get; set; }
        public List<UserListDto> userListDtos { get; set; }

    }
}
