using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserOperationClaimService
    {
        Task<List<UserOperationClaim>>GetAllAsync();
        Task AddAsync(UserOperationClaim entity);
        Task UpdateAsync(UserOperationClaim entity);
        Task DeleteAsync(UserOperationClaim entity);
    }
}
