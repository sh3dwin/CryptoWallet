using System;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    public class CryptoValue
    {
        private String code;
        public float currentValue { get; private set; }
        public float[] highs { get; private set; }
        public float[] lows { get; private set; }

        public CryptoValue(String code)
        {
            this.code = code;
            this.highs = new float[100];
            this.lows = new float[100];
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
                String linee = "";
                linee = Regex.Replace(line, @"\s+", @" ");
                String[] lineData = linee.Split(' ');

               
                float.TryParse(lineData[2], out highs[index]);
                float.TryParse(lineData[3], out lows[index]);
                index++;
            }
        }

        public void update()
        {
            this.loadData();
        }

        public float getMin()
        {
            float min = float.MaxValue;
            for(int i = 0; i < 31; i++)
            {
                if (lows[i] < min)
                    min = lows[i];
            }
            return min;
        }

        public void draw(Graphics graphic, float x1, float y1, float x2, float y2)
        {
            float height = Math.Abs(y1 - y2);
            float width = Math.Abs(x1 - x2);
            float step = width / 31.0f;
            float max = highs.Max();
            float min = getMin();
            float difference = max - min;
            
            for(int i = 0; i < 31; i++)
            {
                //normalizing data between 0 and 1
                float dayLow = (lows[i] - min) / difference;
                float dayHigh = (highs[i] - min) / difference;
                float nextDayLow = (lows[i + 1] - min) / difference;


                Pen positivePen = new Pen(Color.Green, 3.0f);
                Pen negativePen = new Pen(Color.Red, 3.0f);
                // i * step, (lows[i] / difference) * height
                // i * step, (highs[i] / difference) * height
                Pen currentPen = positivePen;
                if (i != 0 && highs[i - 1] > highs[i])
                    currentPen = negativePen;

                //Drawing that days price fluctuation
                graphic.DrawLine(currentPen,
                    i * step, height - dayLow * height,
                    i * step, height - dayHigh * height);

                if (i != 30)
                {
                    currentPen = negativePen;
                    if(highs[i] < highs[i + 1])
                    {
                        currentPen = positivePen;
                    }
                    currentPen.Width = 1.0f;
                    currentPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

                    //Drawing the transition to the next days high
                    graphic.DrawLine(currentPen,
                        i * step, height - dayHigh * height,
                        (i + 1) * step, height - nextDayLow * height);
                }
                else
                {
                    currentPen.Dispose();
                    positivePen.Dispose();
                    negativePen.Dispose();
                    Pen dottedLinePen = new Pen(Color.Black, 1.0f);
                    dottedLinePen.DashPattern = new float[] { 5, 15, 5, 15};
                    graphic.DrawLine(dottedLinePen, 0, height * 0.95f, width, height * 0.95f);
                    graphic.DrawLine(dottedLinePen, 0, height * 0.05f, width, height * 0.05f);
                    dottedLinePen.Dispose();
                }
                   
            }
        }
        
    }
}
