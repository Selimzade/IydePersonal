﻿using IydePersonal.Application.Dtos.Store;
using IydePersonal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Dtos.Employee
{
    public class EmployeeAddDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public WorkPosition WorkPosition { get; set; }
        
        public bool IsActive { get; set; }=false;
        public int FixSalary { get; set; }
        public string Adress { get; set; }

        public IList<StoreDto> stores { get; set; }
        public DateTime StartWork { get; set; } = DateTime.Now;


    }
}