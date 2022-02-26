using MVCUI.Models.PlanStatus;

namespace MVCUI.Services.Abstract
{
    public interface IPlanStatusService
    {
        Task<List<PlanStatusView>> GetAll();
    }
}
