using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtomicHabits.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AtomicHabits.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public UserController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("register")]
        public async Task<ActionResult> SignUp(SignUpDto user)
        {
            var existingUser = await _userManager.FindByEmailAsync(user.Email);
            if (existingUser != null)
            {
                return BadRequest("user already exisits");
            }

            var newUser = new IdentityUser { UserName = user.Email, Email = user.Email };
            IdentityResult result = await _userManager.CreateAsync(newUser, user.Password);

            return Ok(result);

        }
    }
}