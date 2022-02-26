using Core.Entities.EntityFramework.Concrete;
using Core.Utilities.Results;
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
       
        User GetByMailAndPassword(string email, string password);
        




    }
}
