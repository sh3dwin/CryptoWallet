using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    public class Wallet
    {
        private double btcAmount;
        private double ethAmount;
        private double adaAmount;
        private double usdtAmount;
        private double dogeAmount;
        private double solAmount;
        private double bchAmount;
        private double vetAmount;

        private List<String> transactionHistory;


        public Wallet()
        {
            btcAmount  = 0.0f;
            ethAmount  = 0.0f;
            adaAmount  = 0.0f;
            usdtAmount = 0.0f;
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


        public double getAmount(String code)
        {
            switch (code)
            {
                case "btc":  return btcAmount;
                case "eth":  return ethAmount;
                case "ada":  return adaAmount;
                case "usdt": return usdtAmount;
                case "doge": return dogeAmount;
                case "sol":  return solAmount;
                case "bch":  return bchAmount;
                case "vet":  return vetAmount;
                default: return -1;
            }
        }

        public bool addAmount(String code, double amount)
        { 
            switch (code)
            {
                case "btc":  { btcAmount += amount;break; }
                case "eth":  { ethAmount += amount; break;}
                case "ada":  { adaAmount += amount; break;}
                case "usdt": { usdtAmount += amount; break; }
                case "doge": { dogeAmount += amount; break; }
                case "sol":  { solAmount += amount; break; }
                case "bch":  { bchAmount += amount; break; }
                case "vet":  { vetAmount += amount; break; }
                default: return false; 
            }

            transactionHistory.Add(amount.ToString() + " " + code + " deposited into the wallet at " + DateTime.Now.ToString("dd-MM-yyyy") + ", Time:" + DateTime.Now.ToString("HH:mm:ss"));
            return true;  
        }


    }
}
