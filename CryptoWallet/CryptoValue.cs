using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    public class CryptoValue
    {
        private String code;
        public double currentValue { get; private set; }
        public double[] highs { get; private set; }
        public double[] lows { get; private set; }

        public CryptoValue(String code)
        {
            this.code = code;
            this.loadData();
        }

        public void loadData()
        {
            String[] data = System.IO.File.ReadAllLines("..\\data\\data" + this.code + ".txt");
            int index = 0;
            int twoItterations = 0;
            foreach (String line in data)
            {
                if (twoItterations < 2)
                {
                    twoItterations++;
                    continue;
                }
                String linee = Regex.Replace(line, @"\s+", " ");
                String[] lineData = linee.Split(' ');

                double.TryParse(lineData[2], out highs[index]);
                double.TryParse(lineData[3], out lows[index]);
                index++;
            }
        }

        public void update()
        {
            this.loadData();
        }
        
    }
}
