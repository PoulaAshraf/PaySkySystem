using EmploymentApi.Core.Services;

namespace EmploymentApi.Core.Contracts
{
    public interface IUnitOfWork
    {
        IVacancy Vacancy { get; set; }
        IAccountService AccountService { get; set; }
        IVacancyApplication VacancyApplication { get; set; }
        



        int Complete();
    }
}
