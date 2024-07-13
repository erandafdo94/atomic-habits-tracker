using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtomicHabits.Dto;

namespace AtomicHabits.Services.Interfaces
{
    public interface IHabitsService
    {
        Task AddHabit(UserHabitDto habit);
        Task UpdateHabit(UserHabitDto habit);
        Task DeleteHabit(UserHabitDto habit);
    }
}