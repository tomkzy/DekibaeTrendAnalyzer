using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekibaeTrendAnalyzer.Models
{
    public class ConditionSet
    {
        public string Name { get; set; } = "新しい条件セット";
        public DetectFilterCondition FilterCondition { get; set; } = new DetectFilterCondition();
        public SamePositionCondition SamePositionCondition { get; set; } = new SamePositionCondition();
        public AlarmCondition AlarmCondition { get; set; } = new AlarmCondition();
    }
}
