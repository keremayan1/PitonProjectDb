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
        [HttpGet("getplanbyuserid/{userId}")]
        public async Task<IActionResult> GetPlanByUserId(int userId)
        {
            var result = await _planService.GetPlanByUserId(userId);
            return result.IsSuccessful? Ok(result) : BadRequest(result);
        }
        [HttpGet("getbyplanid/{planId}")]
        public async Task<IActionResult> GetByPlanId(int planId)
        {
            var result = await _planService.GetPlanId(planId);
            return result.IsSuccessful ? Ok(result) : BadRequest(result);
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add(Plan plan)
        {
       var result =  await _planService.Add(plan);
            return result.IsSuccessful ? Ok(result) : BadRequest(result);
        }
        [HttpDelete("{planId}")]
        public async Task<IActionResult> Delete(int planId)
        {
         var result =  await _planService.Remove(planId);
            return result.IsSuccessful ? Ok(result) : BadRequest(result);
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(Plan plan)
        {
          var result =   await _planService.Update(plan);
            return result.IsSuccessful ? Ok(result) : BadRequest(result);
        }
    }
}
