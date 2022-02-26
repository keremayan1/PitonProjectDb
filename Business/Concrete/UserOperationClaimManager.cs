using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        IUserOperationClaimDal _userOperationClaimDal;
        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaimDal)
        {
            _userOperationClaimDal = userOperationClaimDal;
        }

        public async Task AddAsync(UserOperationClaim entity)
        {
            await _userOperationClaimDal.AddAsync(entity);
      
        }

        public async Task DeleteAsync(UserOperationClaim entity)
        {
            await _userOperationClaimDal.DeleteAsync(entity);
        
        }

        public async Task<List<UserOperationClaim>> GetAllAsync()
        {
            return await _userOperationClaimDal.GetAllAsync();
        }

        public async Task UpdateAsync(UserOperationClaim entity)
        {
            await _userOperationClaimDal.UpdateAsync(entity);
         
        }
    }
}
