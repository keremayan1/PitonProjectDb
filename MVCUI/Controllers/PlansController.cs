using Core.Utilities.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCUI.Models.Plans;
using MVCUI.Services.Abstract;

namespace MVCUI.Controllers
{
    public class PlansController : Controller
    {
        IPlanService _planService;
        IPlanStatusService _statusService;
      
        public PlansController(IPlanService planService, IPlanStatusService statusService)
        {
            _planService = planService;
            _statusService = statusService;
        }
        
        public async Task<IActionResult> Index(int userId)
        {
            return View(await _planService.GetAllByUserId(1));
        }
        public async Task<IActionResult> AddPlan()
        {
            var result = await _statusService.GetAll();
            ViewBag.planStatus = new SelectList(result,"Id","Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddPlan(AddPlanInput addPlanInput)
        {
            var result = await _statusService.GetAll();
            ViewBag.planStatus = new SelectList(result, "Id", "Name");
            if (ModelState.IsValid)
            {
                return View();
            }
            await _planService.AddPlan(addPlanInput);
            return RedirectToAction(nameof(HomeController));
        }
        public async Task<IActionResult> Update(int id)
        {
            var plans = await _planService.GetByPlanId(id);
            var status = await _statusService.GetAll();
            if (plans==null)
            {
                RedirectToAction(nameof(Index));
            }
            ViewBag.plans = new SelectList(status, "Id", "Name",plans.Id);
            var updatePlanInput = new UpdatePlanInput
            {
                Id = plans.Id,
                Comment = plans.Comment,
                Day = plans.Day,
                //PlanStatusName = plans.PlanStatusName,
                UserId = plans.UserId,
                PlanStatusId = plans.PlanStatusId,
            };
            return View(updatePlanInput);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdatePlanInput updatePlanInput)
        {
            var status = await _statusService.GetAll();
            ViewBag.plans = new SelectList(status, "Id", "Name", updatePlanInput.Id);
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _planService.Update(updatePlanInput);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _planService.DeletePlan(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
