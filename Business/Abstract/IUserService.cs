using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        Task<List<User>> GetAll();
        Task Add(User entity);
        Task Update(User entity);
        Task Delete(User entity);
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email,string password);
      



    }
}
