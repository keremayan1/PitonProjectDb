using MVCUI.Models.Plans;

namespace MVCUI.Services.Abstract
{
    public interface IPlanService
    {
        Task<bool> AddPlan(AddPlanInput addPlanInput);
        Task<bool> DeletePlan(int id);
        Task<List<PlanView>> GetAllByUserId(int userId);
        Task<bool> Update(UpdatePlanInput updatePlanInput);
        Task<PlanView> GetByPlanId(int planId);

    }
}
