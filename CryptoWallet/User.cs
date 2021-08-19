using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    public class User
    {
        public String password {  get; private set; }
        public String username { get; private set; }
        public long userID { get; private set; }
        public Wallet wallet { get; private set; }

        public User()
        {
            this.userID = -1;
            this.username = "undefined";
            this.password = "password";
            this.wallet = null;
        }
        public User(String username, String password)
        {
            this.password = password;
            this.username = username;
            Random rand = new Random();
            this.userID = (long) rand.NextDouble();

            this.wallet = new Wallet();
        }

        public bool login(String username, String password)
        {
            return String.Equals(username, this.username) && String.Equals(password, this.password);
        }
    }
}
