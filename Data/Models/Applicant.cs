using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models
{
    public class Applicant
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string ApplicantId { get; set; } 
        public string Qualification { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
