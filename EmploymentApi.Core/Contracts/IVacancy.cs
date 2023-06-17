using EmploymentApi.Core.DTOs;
using Data.Models;

namespace EmploymentApi.Core.Contracts
{
    public interface IVacancy 
    {
        string AddVacancy(VecancyDTO vacancy);
        string EditVacancy(int vacancyId, VecancyDTO vacancy);
        string RemoveVacancy(int vacancyId);
        List<Vacancy> GetAllVacancies();
        Vacancy GetVacancyByID(int id);
        List<Vacancy> GetVacancyByName(string title);

        void ArchivingExpiredVacancies();

    }
}
