using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PlanStatusManager : IPlanStatusService
    {
        IPlanStatusDal _planStatusDal;
        public PlanStatusManager(IPlanStatusDal planStatusDal)
        {
            _planStatusDal = planStatusDal;
        }

        public async Task<Response<List<PlanStatus>>> GetAll()
        {
            return Response<List<PlanStatus>>.Success(await _planStatusDal.GetAllAsync(),200);
        }
    }
}
