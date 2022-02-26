using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto
{
    public class PlanDto:IDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PlanStatusId { get; set; }
        public string PlanStatusName { get; set; }

        public int Time { get; set; }
        public string Comment { get; set; }
    }
}
