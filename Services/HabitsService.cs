using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtomicHabits.Common;
using AtomicHabits.Dto;
using AtomicHabits.Repository;
using AtomicHabits.Repository.Modal;
using AtomicHabits.Services.Interfaces;
using AutoMapper;

namespace AtomicHabits.Services
{

    public class HabitsService : IHabitsService
    {
        private readonly IBaseRepository<UserHabits> _baseRepo;
        private readonly IMapper _mapper;

        public HabitsService(IBaseRepository<UserHabits> baseRepo, IMapper mapper)
        {
            _baseRepo = baseRepo;
            _mapper = mapper;
        }

        public async Task AddHabit(UserHabitDto habit)
        {
            var habitForDb = _mapper.Map<UserHabitDto, UserHabits>(habit);
            habitForDb.UserId = "ccbadc5b-1314-4ea9-8426-1f6fced65931";
            await _baseRepo.AddAsync(habitForDb);
        }

        public async Task DeleteHabit(int habitId)
        {
            var existingHabit = await _baseRepo.GetByIdAsync(habitId);

            if (existingHabit == null)
            {
                throw new Exception("Habit does not exists");
            }
            await _baseRepo.DeleteAsync(existingHabit);
        }

        public async Task UpdateHabit(UserHabitDto habit, int habitId)
        {
            var existingHabit = await _baseRepo.GetByIdAsync(habitId);

            if (existingHabit == null)
            {
                throw new Exception("Habit does not exists");
            }

            var habitForDb = _mapper.Map<UserHabitDto, UserHabits>(habit);
            await _baseRepo.UpdateAsync(habitForDb);
        }
    }
}