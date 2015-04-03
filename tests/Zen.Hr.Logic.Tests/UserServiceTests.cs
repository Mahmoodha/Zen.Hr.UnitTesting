using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zen.Hr.Logic;

namespace Zen.Hr.Logic.Tests
{
    [TestClass]
    public class UserServiceTests
    {
        [TestMethod]
        public void Successfully_Returns_All_Users_When_Passing_In_False()
        {
            FetchUsers da = new FetchUsers();
            UserService us = new UserService(da);

            //Arrange
            User[] uc = new User[4];
            uc[0] = new User { UserName = "John", IsActive = false };
            uc[1] = new User { UserName = "Adam", IsActive = true };
            uc[2] = new User { UserName = "Shane", IsActive = false };
            uc[3] = new User { UserName = "Bob", IsActive = false };

            da.UserCollection = uc;
            User[] result = us.GetUsers();

            //Assert
            Assert.AreEqual(uc.Length, result.Length);
        }

        [TestMethod]
        public void Successfully_Returns_All_Active_Users_When_Passing_In_True()
        {
            FetchUsers da = new FetchUsers();
            UserService us = new UserService(da);

            //Arrange
            User[] uc = new User[4];
            uc[0] = new User { UserName = "John", IsActive = false };
            uc[1] = new User { UserName = "Adam", IsActive = true };
            uc[2] = new User { UserName = "Shane", IsActive = false };
            uc[3] = new User { UserName = "Bob", IsActive = false };

            da.UserCollection = uc;
            User[] result = us.GetUsers(true);

            //Assert
            Assert.AreEqual(1, result.Length);
        }
    }
}
