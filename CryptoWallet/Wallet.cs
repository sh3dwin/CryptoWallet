using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    public class Wallet
    {
        public float btcAmount { get; private set; }
        public float ethAmount { get; private set; }
        public float adaAmount { get; private set; }
        public float dogeAmount { get; private set; }
        public float solAmount { get; private set; }
        public float bchAmount { get; private set; }
        public float vetAmount { get; private set; }

        private List<String> transactionHistory;


        public Wallet()
        {
            btcAmount  = 0.0f;
            ethAmount  = 0.0f;
            adaAmount  = 0.0f;
            dogeAmount = 0.0f;
            solAmount  = 0.0f;
            bchAmount  = 0.0f;
            vetAmount  = 0.0f;

            transactionHistory = new List<String>();
        }

        public override String ToString()
        {
            return "Wallet to STRING\n";
        }

        public bool addAmount(String code, float amount)
        { 
            switch (code)
            {
                case "btc":  { btcAmount += amount;break; }
                case "eth":  { ethAmount += amount; break;}
                case "ada":  { adaAmount += amount; break;}
                case "doge": { dogeAmount += amount; break; }
                case "sol":  { solAmount += amount; break; }
                case "bch":  { bchAmount += amount; break; }
                case "vet":  { vetAmount += amount; break; }
                default: return false; 
            }

            transactionHistory.Add(amount.ToString() + " " + code + " deposited into the wallet at " + DateTime.Now.ToString("dd-MM-yyyy") + ", Time:" + DateTime.Now.ToString("HH:mm:ss"));
            return true;  
        }

        public void load(String balance)
        {
            /*String[] amounts = balance.Split(' ');
            float amount = 0;
            float.TryParse(amounts[0], out amount);
            btcAmount = amount;
            float.TryParse(amounts[1], out amount);
            ethAmount = amount;
            float.TryParse(amounts[2], out amount);
            adaAmount = amount;
            float.TryParse(amounts[3], out amount);
            dogeAmount = amount;
            float.TryParse(amounts[4], out amount);
            solAmount = amount;
            float.TryParse(amounts[5], out amount);
            bchAmount = amount;
            float.TryParse(amounts[6], out amount);
            vetAmount = amount;*/
        }


    }
}
