using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsWebAPI.Domain.Entities
{
    public class CaseStatus
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<CaseProgress> CaseProgresses { get; set; }
    }
}
