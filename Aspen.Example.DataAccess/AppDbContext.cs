using Aspen.Example.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aspen.Example.DataAccess
{
    /// <summary>
    /// DB context used for the API database.
    /// </summary>
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        /// <summary>
        /// Represents the user entries into the database.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Represents the roles entries into the database.
        /// </summary>
        public DbSet<Role> Roles { get; set; }

        /// <summary>
        /// Represents the deparment entries into the database.
        /// </summary>
        public DbSet<Department> Departments { get; set; }


        /// <summary>
        /// Represents the user roles entries into the database.
        /// </summary>
        public DbSet<UserRoles> UserRoles { get; set; }

    }
}
