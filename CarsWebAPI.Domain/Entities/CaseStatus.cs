
namespace CarsWebAPI.Domain.Entities
{
    public class CaseStatus
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<CaseProgress> CaseProgresses { get; set; }
    }
}
