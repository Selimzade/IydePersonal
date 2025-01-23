using IydePersonal.Application.Repositories;
using IydePersonal.Domain.Entities.Edentity;
using IydePersonal.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Infrastructure.Repositories
{
    public class UserRepostory : IUserRepository
    {
        private readonly AppDbContext _appDbContext;
        private DbSet<AppUser> Table { get => _appDbContext.Set<AppUser>(); }
        public UserRepostory(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> CountUser(Expression<Func<AppUser, bool>> predicate = null)
        {
            if (predicate is not null)
                return await Table.CountAsync(predicate);
            return await Table.CountAsync();

        }
    }
}
