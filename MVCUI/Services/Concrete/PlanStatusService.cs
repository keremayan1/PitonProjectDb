
using Core.Utilities.Results;
using MVCUI.Models.PlanStatus;
using MVCUI.Services.Abstract;

namespace MVCUI.Services.Concrete
{
    public class PlanStatusService : IPlanStatusService
    {
        private readonly HttpClient _httpClient;

        public PlanStatusService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<PlanStatusView>> GetAll()
        {
            var result = await _httpClient.GetAsync("http://localhost:5068/api/PlanStatus/getall");
            if (!result.IsSuccessStatusCode)
            {
                return null;
            }
            var response = await result.Content.ReadFromJsonAsync<Response<List<PlanStatusView>>>();
            return response.Data;
        }
    }
}
