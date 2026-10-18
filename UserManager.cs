using System.Collections.Generic;

namespace UserManagementSystem
{
    public class UserManager
    {
        private List<string> _users = new List<string>();

        public void AddUser(string username)
        {
            _users.Add(username);
        }
    }
}