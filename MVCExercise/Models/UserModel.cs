using Microsoft.AspNetCore.Identity;
using System;

namespace MVCExercise.Models
{
    public class UserModel : IdentityUser
    {
        public DateTime Registrated { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
