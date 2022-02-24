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

        public async Task<IDataResult<List<PlanStatus>>> GetAll()
        {
            return new SuccessDataResult<List<PlanStatus>>(await _planStatusDal.GetAllAsync());
        }
    }
}
