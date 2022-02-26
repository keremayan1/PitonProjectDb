using Core.Utilities.Results;
using MVCUI.Models.Plans;
using MVCUI.Services.Abstract;
using Newtonsoft.Json;

namespace MVCUI.Services.Concrete
{
    public class PlanService : IPlanService
    {
        private readonly HttpClient _httpClient;

        public PlanService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AddPlan(AddPlanInput addPlanInput)
        {
            var result = await _httpClient.PostAsJsonAsync<AddPlanInput>("http://localhost:5068/api/Plan/add", addPlanInput);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePlan(int id)
        {
            var result = await _httpClient.DeleteAsync($"http://localhost:5068/api/Plan/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<List<PlanView>> GetAllByUserId(int userId)
        {
           
            var result = await _httpClient.GetAsync($"http://localhost:5068/api/Plan/getallbyuserid/{userId}");
            if (!result.IsSuccessStatusCode)
            {
                return null;
            }
         
            var context = await result.Content.ReadFromJsonAsync<Response<List<PlanView>>>();
            return context.Data;
       
        }

        public async Task<PlanView> GetByPlanId(int planId)
        {
            var result = await _httpClient.GetAsync($"http://localhost:5068/api/Plan/getbyplanid/{planId}");
            if (result==null)
            {
                return null;
            }
            var stringContext = await result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<PlanView>(stringContext);
           
        }

        public async Task<bool> Update(UpdatePlanInput updatePlanInput)
        {
            var result = await _httpClient.PostAsJsonAsync<UpdatePlanInput>("http://localhost:5068/api/Plan/update", updatePlanInput);
            return result.IsSuccessStatusCode;
        }
    }
}
