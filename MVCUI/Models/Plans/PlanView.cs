namespace MVCUI.Models.Plans
{
    public class PlanView
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PlanStatusId { get; set; }
        public string PlanStatusName { get; set; }
       
        public int Time { get; set; }
    
        public string Comment { get; set; }
    }
}
