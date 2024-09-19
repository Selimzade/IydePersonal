﻿using IydePersonal.API.Entities;

namespace IydePersonal.Core.Entities
{
    public class Employee
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkPosition { get; set; }
        public string Store { get; set; }
        public bool Active { get; set; }
        public int FixSlary { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime FinishWork { get; set; }
        public int UserId { get; set; }
        public List<EmployeePunkt> employeePunkts { get; set; }
        public List<Salary> salaries { get; set; }

        public User Users { get; set; }

        public List<EmployeeLog> employeeLogs { get; set; }


    }
}
