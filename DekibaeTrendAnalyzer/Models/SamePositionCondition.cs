using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekibaeTrendAnalyzer.Models
{
    public class SamePositionCondition
    {
        public bool UseX { get; set; }
        public bool UseY { get; set; }
        public double MaxDistance { get; set; }
    }
}
