using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace MVCExercise.Model.Membership
{
    public class UserModel : IdentityUser
    {
        public DateTime Registrated { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
