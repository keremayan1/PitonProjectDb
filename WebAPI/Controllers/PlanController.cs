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
        [HttpGet("getallbyuserid/{userId}")]
        public async Task<IActionResult> GetAllByUserId(int userId)
        {
            var result = await _planService.GetPlanDtoByUserId2(userId);
            return result.IsSuccessful? Ok(result) : BadRequest(result);
        }
        [HttpGet("getbyplanid/{planId}")]
        public async Task<IActionResult> GetByPlanId(int planId)
        {
            var result = await _planService.GetPlanId(planId);
            return result.Success ? Ok(result) : BadRequest(result);
        }
        [HttpPost("add")]
        public async Task<IActionResult> Add(Plan plan)
        {
         await _planService.Add(plan);
            return Ok();
        }
        [HttpDelete("{planId}")]
        public async Task<IActionResult> Delete(int planId)
        {
           await _planService.Remove(planId);
            return Ok();
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(Plan plan)
        {
             await _planService.Update(plan);
            return Ok();
        }
    }
}
