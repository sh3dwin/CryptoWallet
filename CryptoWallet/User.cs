using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    public class User
    {
        private bool mutex = false;
        public String password {  get; private set; }
        public String username { get; private set; }
        public List<String> history { get; private set; }
        public Wallet wallet { get; private set; }

        public User()
        {
            this.history = new List<String>();
            this.username = "undefined";
            this.password = "password";
            this.wallet = null;
        }
        public User(String username, String password)
        {
            this.password = password;
            this.username = username;
            Random rand = new Random();
            this.history = new List<String>();

            this.wallet = new Wallet();
        }

        public bool login(String username, String password)
        {
            if (String.Equals(username, this.username) && String.Equals(password, this.password))
            {
                this.loadData();
                return true;
            }
            return false;
        }

        public void addAmount(String code, float amount)
        {
            if(wallet.addAmount(code, amount))
            {
                history.Add(System.DateTime.Now.ToString() + ": Made a deposit of " + amount + " " + code + ".");
                this.writeData();
            }
        }

        public void convert(String code1, float amount1, String code2, float amount2)
        {
            if(wallet.withdrawAmount(code1, amount1) && wallet.addAmount(code2, amount2))
            {
                history.Add(System.DateTime.Now.ToString() + ": Converted " + amount1 + " " + code1.ToUpper() + " to " + amount2 + " " + code2.ToUpper());
                this.writeData();
            }
        }

        public async void writeData()
        {
            String info = wallet.btcAmount.ToString() + " " +
                    wallet.ethAmount.ToString() + " " +
                    wallet.adaAmount.ToString() + " " +
                    wallet.dogeAmount.ToString() + " " +
                    wallet.solAmount.ToString() + " " +
                    wallet.bchAmount.ToString() + " " +
                    wallet.vetAmount.ToString() + "\n";
            foreach(String entry in history)
            {
                info += entry + "\n";
            }
            if (!mutex)
            {
                mutex = true;
                System.IO.StreamWriter file = new System.IO.StreamWriter("../data/" + username + ".txt", append: false);
                await file.WriteLineAsync(info);
                file.Close();
            }
            mutex = false;
        }

        public void loadData()
        {
            if (!mutex)
            {
                mutex = true;
                if (!System.IO.File.Exists("../data/" + username + ".txt"))
                {
                    System.IO.File.Create("../data/" + username + ".txt").Close();
                    
                }
                history.Clear();
                String[] info = System.IO.File.ReadAllLines("../data/" + username + ".txt");
                if (info.Length > 2)
                {
                    wallet.load(info[0]);
                    for (int i = 1; i < info.Length; i++)
                    {
                        if (info[i] == "")
                            continue;
                        history.Add(info[i]);
                    }
                }
            }
            mutex = false;
        }

        public float getAmount(String code)
        {
            switch (code)
            {
                case "btc": return wallet.btcAmount;
                case "eth": return wallet.ethAmount;
                case "ada": return wallet.adaAmount;
                case "doge": return wallet.dogeAmount;
                case "sol": return wallet.solAmount;
                case "bch": return wallet.bchAmount;
                case "vet": return wallet.vetAmount;
                default: return -1;
            }
        }
    }
}
