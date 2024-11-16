using AutoMapper;
using IydePersonal.Application.Dtos.Store;
using IydePersonal.Application.Repositories;
using IydePersonal.Domain.Entities;
using IydePersonal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Infrastructure.Repositories
{
    public class StoreRepostory:IStoreRepostory
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public StoreRepostory(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Store>> GetAllStoreDtos()
        {
            return await _context.Stores.ToListAsync();
        }
    }
}
