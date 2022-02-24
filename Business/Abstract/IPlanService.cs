﻿using Core.Utilities.Results;
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
        Task<IDataResult<Plan>> GetPlan(int planStatus);
        Task<IResult> Add(Plan plan);
        Task<IResult> Remove(int  planId);
        Task<IResult> Update(Plan plan);
    }
}
