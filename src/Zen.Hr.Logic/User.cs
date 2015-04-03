namespace Zen.Hr.Logic
{
    public class User
    {
        public string UserName { get; set; }
        public bool IsActive { get; set; }
        public User()
        {
            UserName = string.Empty;
            IsActive = false;
        }
        public User(string username, bool isactive)
        {
            UserName = username;
            IsActive = isactive;
        }
    }
}