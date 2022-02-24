using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanController : ControllerBase
    {
        IPlanService _planService;

        public PlanController(IPlanService planService)
        {
            _planService = planService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllByUserId(int userId)
        {
            var result = await _planService.GetPlanDtoByUserId(userId);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add(Plan plan)
        {
            var result = await _planService.Add(plan);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int planId)
        {
            var result = await _planService.Remove(planId);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update(Plan plan)
        {
            var result = await _planService.Update(plan);
            return result.Success ? Ok(result) : BadRequest(result);
        }
    }
}
