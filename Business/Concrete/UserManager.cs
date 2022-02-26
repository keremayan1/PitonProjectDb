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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public async Task Add(User entity)
        {
            await _userDal.AddAsync(entity);
            return;
        }
        public async Task Delete(User entity)
        {
            await _userDal.DeleteAsync(entity);
        
        }
        public async Task<List<User>> GetAll()
        {
            return await _userDal.GetAllAsync();
        }

        public User GetByMail(string email,string password)
        {
            var user =_userDal.Get(u => u.Email == email && u.Password==password);
            
            return user;
               
        }
      
        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public async Task Update(User entity)
        {
            await _userDal.UpdateAsync(entity);
           
        }

    }
}
