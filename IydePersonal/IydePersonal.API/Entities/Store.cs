﻿using IydePersonal.Core.Entities;

namespace IydePersonal.API.Entities
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Employee> Employees { get; set; }
       

    }
}
