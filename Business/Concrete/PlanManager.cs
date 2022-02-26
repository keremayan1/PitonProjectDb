using AutoMapper;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PlanManager : IPlanService
    {
        IPlanDal _planDal;

        public PlanManager(IPlanDal planDal)
        {
            _planDal = planDal;
        }
        public async Task<Response<Plan>> Add(Plan plan)
        {
            await _planDal.AddAsync(plan);
            return Response<Plan>.Success(200);
        }
        public async Task<IDataResult<List<PlanDto>>> GetPlanDtoByUserId(int userId)
        {
            var result = await _planDal.GetPlanDto(userId);
            return new SuccessDataResult<List<PlanDto>>(result);
        }

        public async Task<Response<List<PlanDto>>> GetPlanDtoByUserId2(int userId)
        {
            var result = await _planDal.GetPlanDto(userId);
            return Response<List<PlanDto>>.Success(result,200);
        }

        public async Task<IDataResult<Plan>> GetPlanId(int planId)
        {
            var result = await _planDal.GetAsync(x => x.Id == planId);
            return new SuccessDataResult<Plan>(result);
        }

        public async Task<Response<Plan>> Remove(int planId)
        {
            var result = await _planDal.GetAsync(x => x.Id == planId);
            await _planDal.DeleteAsync(result);
            return Response<Plan>.Success(200);

        }

        public async Task<Response<Plan>> Update(Plan plan)
        {
            await _planDal.UpdateAsync(plan);
            return Response<Plan>.Success(200);
        }
    }
}
