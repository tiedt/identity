using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Bierbottle.Identity.Domain.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public List<AppUserRoles> UserRoles { get; set; }
    }
}
