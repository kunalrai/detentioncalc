using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nalasa.DetentionCalculatorLib
{
    public class OffenceType
    {
        public string OffenceName { get; set; }
        public double Period { get; set; }

       
    }

    public class DetentionRule
    {
        public string RuleName { get; set; }
        public int DetentionDiscount { get; set; }
        
    }

    public enum DetentionType
    {
        Concurrent=0,
        Consecutiove=1
    }
}
