using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPlanDal:IEntityRepository<Plan>
    {
        Task<List<PlanDto>> GetPlanDto(Expression<Func<PlanDto, bool>> filter=null);
    }
}
