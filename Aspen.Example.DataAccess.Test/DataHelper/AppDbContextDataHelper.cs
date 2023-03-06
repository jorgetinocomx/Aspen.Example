using Aspen.Example.Entities;

namespace Aspen.Example.DataAccess.Test.DataHelper
{
    /// <summary>
    /// Helps to generate some data (useful when working with the <see cref="DataAccess.AppDbContext"/> class.
    /// </summary>
    internal static class AppDbContextDataHelper
    {

        /// <summary>
        /// Fake users. 
        /// Only for testing purposes.
        /// </summary>
        /// <returns>A list of fake users.</returns>
        internal static  List<User> GetFakeUserList()
        {
            return new List<User>
            {
                new User { FirstName = "Jorge", LastName = "Tinoco"},
                new User { FirstName = "Jorge", LastName = "Tinoco"}
            };
        }
    }
}
