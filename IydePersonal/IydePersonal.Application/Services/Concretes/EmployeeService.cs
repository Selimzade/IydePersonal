﻿using AutoMapper;
using IydePersonal.Application.Dtos.Employee;
using IydePersonal.Application.Repositories;
using IydePersonal.Application.Services.Interfaces;
using IydePersonal.Domain.Entities;
using System;

namespace IydePersonal.Application.Services.Concretes
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        //private readonly AppDbContext _context;


        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<EmployeeDto>> GetEmployeeList()
        {
            var employees = await _employeeRepository.GetEmployeesAsync(x=>x.IsActive,x=>x.Store);
            var dto = _mapper.Map<IEnumerable<EmployeeDto>>(employees);
            return dto;
        }
        public async Task<EmployeeDto> GetEmployeeById(int UpdateId)
        {
            var emp = await _employeeRepository.GetAsync(x=>x.IsActive&&x.Id==UpdateId);
            var employees = _mapper.Map<EmployeeDto>(emp);
            return employees;
        }
        public async Task CreateEmployee(EmployeeAddDto employeeAddDto)
        {
            var userId = 1;
            var emp = new Employee
            {
                FirstName = employeeAddDto.FirstName,
                LastName = employeeAddDto.LastName,
                Gender = employeeAddDto.Gender,
                DateOfBirth = employeeAddDto.DateOfBirth,
                PhoneNumber = employeeAddDto.PhoneNumber,
                WorkPosition = employeeAddDto.WorkPosition,
              //  IsActive = employeeAddDto.IsActive,
                FixSalary = employeeAddDto.FixSalary,
                Adress = employeeAddDto.Adress,
                StoreId = employeeAddDto.StoryId,
                StartWork = employeeAddDto.StartWork,
                UserId = userId,

            };
            await _employeeRepository.CreateEmployee(emp);
            await _employeeRepository.SaveAsync();
        }

        public async Task SoftDeleteEmployee(int UpdateId)
        {
            var emp = await _employeeRepository.GetEmployeeById(UpdateId);
            emp.IsActive = false;
            emp.FinishWork=DateTime.Now;
            await _employeeRepository.UpdateEmplyee(emp);
            await _employeeRepository.SaveAsync();
         }



        public async Task UpdateEmployee(EmployeeUpdateDto employeeUpdateDto)
        {

            var updateemp = await _employeeRepository.GetAsync(x=>x.IsActive && x.Id == employeeUpdateDto.Id);
            _mapper.Map(employeeUpdateDto, updateemp);
            updateemp.ModifiedDate = DateTime.Now;
            //_mapper.Map<EmployeeUpdateDto>(updateemp);
          //  updateemp.FirstName = employeeUpdateDto.FirstName;
          //  updateemp.LastName = employeeUpdateDto.LastName;
          //  updateemp.Gender = employeeUpdateDto.Gender;
          //  updateemp.DateOfBirth = employeeUpdateDto.DateOfBirth;
          //  updateemp.PhoneNumber = employeeUpdateDto.PhoneNumber;
          //  updateemp.WorkPosition = employeeUpdateDto.WorkPosition;
          //  updateemp.FixSalary = employeeUpdateDto.FixSalary;
          //  updateemp.Adress = employeeUpdateDto.Adress;
          ////  updateemp.IsActive = employeeUpdateDto.IsActive;
          //  updateemp.StoreId = employeeUpdateDto.StoryId;
          //  updateemp.StartWork = employeeUpdateDto.StartWork;
            await _employeeRepository.UpdateEmplyee(updateemp);
            await _employeeRepository.SaveAsync();

        }
    }
}
