using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    class Vehicle
    {
        public string Name { get; set; }
        public string RegNo { get; set; }
        public List<int> SpeedList { get; set; }
        
        public int GetMinimumSpeed()
        {
            return SpeedList.Min();
        }
        public int GetMaximumSpeed()
        {
            return SpeedList.Max();
        }
        public decimal GetAverageSpeed()
        {
            decimal averageSpeed = Convert.ToDecimal(SpeedList.Average());
            return averageSpeed;
        }
    }
}
