using Aspen.Example.DataAccess.Test.DataHelper;
using Aspen.Example.Entities;
using MockQueryable.Moq;
using Moq;

namespace Aspen.Example.DataAccess.Test
{
    /// <summary>
    /// Testing the UserData repository.
    /// </summary>
    [TestClass]
    public class UserDataTest
    {

        
        /// <summary>
        /// Get must return any value.
        /// </summary>
        [TestMethod]
        public void Get_MustReturnSomeValue()
        {
            // Arrange
            var mock = AppDbContextDataHelper
                            .GetFakeUserList()
                            .BuildMock()
                            .BuildMockDbSet();
            var userContextMock = new Mock<AppDbContext>();
            userContextMock.Setup(x => x.Users).Returns(mock.Object);

            // Act
            var dataService = new UserData(userContextMock.Object);
            var users = dataService.Get();

            // Assert
            Assert.IsTrue(users.Any());
        }

        /// <summary>
        /// When adding a user. An identifier (primary key) must be generated in order to know 
        /// if the user was added properly.
        /// </summary>
        [TestMethod]
        public void NewUser_MustExecuteCorrectly()
        {
            // Arrange 
            var mock = AppDbContextDataHelper
                            .GetFakeUserList()
                            .BuildMock()
                            .BuildMockDbSet();
            var userContextMock = new Mock<AppDbContext>();
            userContextMock.Setup(x => x.Users).Returns(mock.Object);

            var newFakeUser = new User { UserId = 3,  FirstName = "Fulanito", LastName = "De tal" };

            // Act
            var dataService = new UserData(userContextMock.Object);
            var addedUser = dataService.NewUser(newFakeUser);

            // Assert
            Assert.IsTrue(addedUser.UserId > 0);
        }
    }
}