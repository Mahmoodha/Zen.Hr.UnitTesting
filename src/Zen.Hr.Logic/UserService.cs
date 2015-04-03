namespace Zen.Hr.Logic
{
    public class UserService
    {
        private readonly IUserDataAccess dataAccess;

        public UserService(IUserDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        public User[] GetUsers(bool activeOnly = false)
        {
            if (activeOnly)
                return dataAccess.GetAllActiveUsers();

            return dataAccess.GetAllUsers();
        }
    }
}
