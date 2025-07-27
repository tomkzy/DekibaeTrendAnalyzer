using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekibaeTrendAnalyzer.Models
{
    public class AlarmCondition
    {
        public int MinConsecutiveCount { get; set; }
        public int MinDefectCount { get; set; }
    }

}
