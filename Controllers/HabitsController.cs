using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IActionResult> AddHabit([FromBody] UserHabitDto habit)
        {
            var result = _habitsService.AddHabit(habit);
            return Ok(result.ToString());
        }
    }
}