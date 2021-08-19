using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    public class UserDoc
    {
        private List<User> users;

        public UserDoc()
        {
            this.users = new List<User>();
        }

        public bool userExists(String username)
        {
            foreach (User user in users)
            {
                if (String.Equals(user.username, username))
                    return true;
            }
            return false;
        }
        public void addUser(String username, String password)
        {
            this.users.Add(new User(username, password));
        }

        public User logInUser(String username, String password)
        {
            foreach (User user in users)
            {
                if (user.login(username, password))
                    return user;
            }
            return null;
        }
    }
}
