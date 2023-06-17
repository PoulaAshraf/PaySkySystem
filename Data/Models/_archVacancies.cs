using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class _archVacancies
    {
        [Key]
        public int ArchivedVacancyId { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription { get; set; }
        public string JobType { get; set; }
        public DateTime PostedDate { get; set; } = DateTime.Now;
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; } = true;
        public int MaxApplicant { get; set; }
        public int NoOfApplied { get; set; }
    }
}
