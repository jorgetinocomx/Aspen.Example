using Aspen.Example.Entities;

namespace Aspen.Example.DataAccess.Interfaces
{
    /// <summary>
    /// Defines the interfaces/contracts for the user data access.
    /// </summary>
    public interface IUserData
    {
        /// <summary>
        /// Inserts a record in the user table.
        /// </summary>
        /// <param name="newUserData">Required data to create a new user/record.</param>
        public User NewUser(User newUserData);

        /// <summary>
        /// Gets the IQueryable object (used to perform some operations).
        /// </summary>
        public IQueryable<User> Get();
    }
}
