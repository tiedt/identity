using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Bierbottle.Identity.Domain.Models
{
    public class AppRole : IdentityRole<Guid>
    {
        public List<AppUserRoles> UserRoles { get; set; }
    }
}
