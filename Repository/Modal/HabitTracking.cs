using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AtomicHabits.Repository.Modal
{
    public class HabitTracking
    {
        public int Id { get; set; }
        public DateOnly TrackData { get; set; }
        public bool Status { get; set; } = false;

        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        public int HabitId { get; set; }
        [ForeignKey("HabitId")]
        public UserHabits UserHabits { get; set; }

    }
}