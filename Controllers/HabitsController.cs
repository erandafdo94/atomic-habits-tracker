using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtomicHabits.Common;
using AtomicHabits.Dto;
using AtomicHabits.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AtomicHabits.Controllers
{
    [ApiController]
    [Route("api/habits")]
    public class HabitsController : ControllerBase
    {
        private readonly IHabitsService _habitsService;

        public HabitsController(IHabitsService habitsService)
        {
            _habitsService = habitsService;
        }

        [HttpPost("add-habit")]
        public async Task<IActionResult> AddHabit(UserHabitDto habit)
        {
            await _habitsService.AddHabit(habit);
            return Ok(
                 GenericResponse<object>.SuccessResponse(
                     null,
                     "Success!"
                 )
             );
        }

        [HttpPost("update-habit")]
        public async Task<IActionResult> AddHabit(UserHabitsUpdateDto habit)
        {
            await _habitsService.UpdateHabit(habit);
            return Ok(
                 GenericResponse<object>.SuccessResponse(
                     null,
                     "Success!"
                 )
             );
        }

        [HttpPost("delete-habit")]
        public async Task<IActionResult> DeleteHabit(int habitId)
        {
            await _habitsService.DeleteHabit(habitId);
            return Ok(
                 GenericResponse<object>.SuccessResponse(
                     null,
                     "Success!"
                 )
             );
        }
    }
}