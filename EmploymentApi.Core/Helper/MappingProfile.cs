using AutoMapper;
using EmploymentApi.Core.DTOs;
using Data.Models;
using System;

namespace EmploymentApi.Core.Helper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Vacancy, VecancyDTO>().ReverseMap();
        }
    }
}
