using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    internal class TimePeriod
    {
        int seconds;
        
        public double Hours
        {
            get
            {
                return (double)seconds / 3600;
            }
            set
            {
                seconds=(int)(value * 3600);
            }
        }
        public TimePeriod(int seconds)
        {
            this.seconds = seconds;
        }
        public void DisplaySeconds()
        {
            Console.WriteLine($"Time in seconds: {seconds} seconds");
        }
    }
}
