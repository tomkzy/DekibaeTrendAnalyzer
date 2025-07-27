using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekibaeTrendAnalyzer.Models
{
    public class DetectFilterCondition
    {
        public List<string> ProcessNames { get; set; } = new List<string>();
        public Range<double>? XRange { get; set; }
        public Range<double>? YRange { get; set; }
        public Range<double>? SizeRange { get; set; }
        public Range<double>? GrayRange { get; set; }
        public Range<double>? SobelRange { get; set; }
    }
}
