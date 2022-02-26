using Core.DataAccess.EntityFramework.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserOperationClaimDal : EfEntityRepository<UserOperationClaim, SqlContext>, IUserOperationClaimDal
    {
        public EfUserOperationClaimDal(SqlContext context) : base(context)
        {
        }
    }
}
