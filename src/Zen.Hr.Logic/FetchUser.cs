using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zen.Hr.Logic
{
    public class FetchUsers : IUserDataAccess
    {
        public User[] UserCollection { get; set; }

        public User[] GetAllUsers()
        {
            var userQuery = from user in UserCollection
                            orderby user.UserName
                            select user;
            return userQuery.ToArray();
        }
        public User[] GetAllActiveUsers()
        {
            var userQuery = from user in UserCollection
                            where user.IsActive == true
                            orderby user.UserName
                            select user;
            return userQuery.ToArray();
        }
    }
}
