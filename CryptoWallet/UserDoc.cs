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
        public async void addUser(String username, String password)
        {
            if (!System.IO.File.Exists("./userData.txt"))
            {
                System.IO.File.Create("./userData.txt").Close();
            }
            this.users.Add(new User(username, password));
            System.IO.StreamWriter file = new System.IO.StreamWriter("./userData.txt", append: true);
            await file.WriteLineAsync(username + " " + password);
            file.Close();
        }

        public void loadUser(String username, String password)
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

        public void loadData()
        {
            if (!System.IO.File.Exists("./userData.txt"))
            {
                System.IO.File.Create("./userData.txt").Close();
            }
            String[] users = System.IO.File.ReadAllLines("./userData.txt");
            foreach (String line in users)
            {
                this.loadUser(line.Split(' ')[0], line.Split(' ')[1]);
            }
        }
    }
}
