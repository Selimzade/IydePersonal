using AutoMapper;
using IydePersonal.Application.Dtos.SalaryDto;
using IydePersonal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Profiles
{
    public class SalaryProfile:Profile
    {
        public SalaryProfile()
        {
                CreateMap<Salary,SalaryListDto>().ReverseMap();
        }
    }
}
