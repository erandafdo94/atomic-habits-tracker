using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AtomicHabits.Repository.Modal
{
    public class UserHabits
    {
        public int Id { get; set; }
        public string HabitName { get; set; }

        //Navigation properties
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
    }
}