using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanStatusController : ControllerBase
    {
        IPlanStatusService _planStatusService;

        public PlanStatusController(IPlanStatusService planStatusService)
        {
            _planStatusService = planStatusService;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var result= await _planStatusService.GetAll();
            return result.IsSuccessful ? Ok(result) : BadRequest(result);
        }
    }
}
