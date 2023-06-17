using EmploymentApi.Core.DTOs;

namespace EmploymentApi.Core.Contracts
{
    public interface IVacancyApplication
    {
        Task<AppliedVacancyDTO> GetApplicationsByVacancy(int id);
        string ApplyOnVacancy(int vacancyId, string applicantId);
    }
}
