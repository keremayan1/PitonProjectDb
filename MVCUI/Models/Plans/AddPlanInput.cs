using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCUI.Models.Plans
{
    public class AddPlanInput
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PlanStatusId { get; set; }
        [Display(Name ="Durum Ad")]
        public string PlanStatusName { get; set; }
        [Display(Name = "Gun")]
        public int Day { get; set; }
        [Display(Name = "Yorum ")]
        public string Comment { get; set; }
    }
}
