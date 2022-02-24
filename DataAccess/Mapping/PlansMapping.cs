using AutoMapper;
using Entities.Concrete;
using Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class PlansMapping:Profile
    {
        public PlansMapping()
        {
            CreateMap<Plan, PlanDto>().ReverseMap();
            CreateMap<PlanStatus, PlanDto>().ReverseMap();
        }
    }
}
