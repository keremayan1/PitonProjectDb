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
        public async Task<IResult> Add(Plan plan)
        {
            await _planDal.AddAsync(plan);
            return new SuccessResult();
        }

        public async Task<IDataResult<Plan>> GetPlan(int planStatus)
        {
            var result = await _planDal.GetAsync(x => x.UserId == planStatus);
            return new SuccessDataResult<Plan>(result);
        }

        public async Task<IDataResult<List<PlanDto>>> GetPlanDtoByUserId(int userId)
        {
            var result = await _planDal.GetPlanDto(x => x.UserId == userId);
            return new SuccessDataResult<List<PlanDto>>(result);
        }

        public async Task<IResult> Remove(int planId)
        {
            var result = await _planDal.GetAsync(x => x.Id == planId);
            await _planDal.DeleteAsync(result);
            return new SuccessResult();
        }

        public async Task<IResult> Update(Plan plan)
        {
            await _planDal.UpdateAsync(plan);
            return new SuccessResult();
        }
    }
}
