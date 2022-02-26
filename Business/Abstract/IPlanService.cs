
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPlanService
    {
        Task<IDataResult<List<PlanDto>>> GetPlanDtoByUserId(int userId);
        Task<Response<List<PlanDto>>> GetPlanDtoByUserId2(int userId);
        Task<IDataResult<Plan>> GetPlanId(int planId);
        Task<Response<Plan>> Add(Plan plan);
        Task<Response<Plan>> Remove(int  planId);
        Task<Response<Plan>> Update(Plan plan);
    }
}
