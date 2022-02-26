using System.ComponentModel.DataAnnotations;

namespace MVCUI.Models.Plans
{
    public class UpdatePlanInput
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PlanStatusId { get; set; }
        [Display(Name = "Zaman")]
     
        public int Time { get; set; }
        [Display(Name = "Yorum ")]
        public string Comment { get; set; }
    }
}
