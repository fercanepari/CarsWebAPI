using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsWebAPI.Domain.Entities
{
    public class CaseProgress
    {
        public int ProgressId { get; set; }
        public int CarId { get; set; }
        public int StatusId { get; set; }
        public DateTime StatusDate { get; set; }
        public string ChangedBy { get; set; }

        public virtual Car Car { get; set; }
        public virtual CaseStatus Status { get; set; }
    }
}
