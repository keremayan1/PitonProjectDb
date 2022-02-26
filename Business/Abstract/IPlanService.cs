
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
       
        Task<Response<List<PlanDto>>> GetPlanByUserId(int userId);
        Task<Response<Plan>> GetPlanId(int planId);
        Task<Response<Plan>> Add(Plan plan);
        Task<Response<Plan>> Remove(int  planId);
        Task<Response<Plan>> Update(Plan plan);
    }
}
