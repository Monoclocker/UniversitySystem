using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using UniversitySystem.Models;

namespace UniversitySystem.Data
{
    public class DBContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        
    }
}
