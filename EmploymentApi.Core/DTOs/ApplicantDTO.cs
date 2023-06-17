using System.ComponentModel.DataAnnotations;

namespace EmploymentApi.Core.DTOs
{
    public class ApplicantDTO
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Qualification { get; set; }
    }
}
