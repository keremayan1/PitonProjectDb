using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IPlanStatusService
    {
        Task<Response<List<PlanStatus>>>GetAll();
       
    }
}
