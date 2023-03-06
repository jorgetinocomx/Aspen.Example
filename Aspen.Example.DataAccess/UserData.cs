using Aspen.Example.DataAccess.Interfaces;
using Aspen.Example.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aspen.Example.DataAccess
{
    /// <summary>
    /// In charge of get the information directly from the database.
    /// </summary>
    /// <remarks>
    /// This implementation uses MS SQL server as the DB provider.
    /// </remarks>
    public class UserData : IUserData
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Injects the AppDbContext.
        /// </summary>
        /// <param name="context">Created instance for the context.</param>
        public UserData(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// IMPLEMENTATION to: get the IQueryable object (used to perform some operations).
        /// </summary>
        public IQueryable<User> Get()
        {
            return _context
                    .Users
                    .Include( x=> x.UserDepartment)
                    .AsQueryable();
        }

        /// <summary>
        /// IMPLEMENTATION to: Insert a record in the user table.
        /// </summary>
        /// <param name="newUserData">Required data to create a new user/record.</param>
        public User NewUser(User newUserData)
        {
            _context
                   .Users
                   .Add(newUserData);
            _context.SaveChanges();
            return newUserData;
        }
    }
}
