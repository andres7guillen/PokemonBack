using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonDomain.Entities.Security
{
    public class ApplicationUser : IdentityUser<Guid>
    {
    }

    public class UserRole : IdentityRole<Guid>
    {
    }
}
