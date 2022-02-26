using System.ComponentModel.DataAnnotations;

namespace MVCUI.Models.Plans
{
    public class UpdatePlanInput
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PlanStatusId { get; set; }
        [Display(Name = "Durum Ad")]
     
        public int Day { get; set; }
        [Display(Name = "Yorum ")]
        public string Comment { get; set; }
    }
}
