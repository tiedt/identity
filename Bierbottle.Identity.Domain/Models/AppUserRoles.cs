using Microsoft.AspNetCore.Identity;
using System;

namespace Bierbottle.Identity.Domain.Models
{
    public class AppUserRoles : IdentityUserRole<Guid>
    {
        public AppUser User { get; set; }
        public AppRole Role { get; set; }
    }
}
