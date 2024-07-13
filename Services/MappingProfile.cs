using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtomicHabits.Dto;
using AtomicHabits.Repository.Modal;
using AutoMapper;

namespace AtomicHabits.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserHabitDto, UserHabits>();
        }

    }
}