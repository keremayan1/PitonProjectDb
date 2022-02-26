using Core.DataAccess.EntityFramework.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.Concrete.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPlanDal : EfEntityRepository<Plan, SqlContext>, IPlanDal
    {
       

        public EfPlanDal(SqlContext context) : base(context)
        {
        }

        public async Task<List<PlanDto>> GetPlanDto(int userId)
        {
           var list = await(from p in _context.Plans
                            join p2 in _context.PlanStatus on p.PlanStatusId equals p2.Id
                            where p.UserId==userId
                            select new PlanDto
                            {
                                Id = p.Id,
                                UserId= p.UserId,
                                Day=p.Day,
                                PlanStatusName=p2.Name,
                                Comment=p.Comment,
                                PlanStatusId=p.PlanStatusId
                            }).ToListAsync();
            return list;
        }
    }
}
