using EmploymentApi.Core.DTOs;

namespace EmploymentApi.Core.Contracts
{
    public interface IAccountService
    {
        Task<AuthDTO> Login(LoginDTO model);
        Task<AuthDTO> RegisterAsync(RegisterDTO model);
        Task<AuthDTO> EmployerRegisterAsync(EmployerDTO employer);
        Task<AuthDTO> ApplicantRegisterAsync(ApplicantRegisterDTO applicant);
    }
}
