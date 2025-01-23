using IydePersonal.Domain.Entities.Edentity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IydePersonal.Application.Repositories
{
    public interface IUserRepository
    {
        Task<int> CountUser(Expression<Func<AppUser, bool>> predicate = null);
    }
}
