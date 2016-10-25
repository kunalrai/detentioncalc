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
        
        public int DetentionPeriod { get; set; }


        private Dictionary<string, int> _store = new Dictionary<string, int>();
        public void AddDetentionRule(string name, int period)
        {
            if (_store.ContainsKey(name))
            {
                _store[name] = period;
            }
            else
                _store.Add(name, period);
        }

    }

    public class DetentionType
    {

    }
}
