using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nalasa.DetentionCalculatorLib
{
    public class DetentionCalculator:IDetentionCalculator
    {
        public Dictionary<string, double> _store = new Dictionary<string, double>();
        public Dictionary<string, double> _rulestore = new Dictionary<string, double>();

        public double CalculateDetention(List<OffenceType> offtypes, DetentionRule rule, DetentionType det_type)
        {
            var det_Period=0.0;
            foreach (var item in offtypes)
            {
                det_Period += item.Period;
            }

            det_Period = CalculteDiscount(det_Period,rule.DetentionDiscount);

            if (det_Period > 8)
                throw new Exception("Period greator than 8 Hrs. Parent concerns required");
            return det_Period;
        }

        private double CalculteDiscount(double det_Period, int p)
        {
            var s = (p * det_Period) / 100;

            return det_Period - s;
        }

        public void AddDetentionRule(DetentionRule rule)
        {
            var name = rule.RuleName;
            var period =rule.DetentionDiscount;
           if (_rulestore.ContainsKey(name))
            {
                _rulestore[name] = period;
            }
            else
                _rulestore.Add(name, period);
        }
       
        public void AddOffenceType(OffenceType offenceType)
        {
            var name = offenceType.OffenceName;
            var period = offenceType.Period;
            if (_store.ContainsKey(name))
            {
                _store[name] = period;
            }
            else
                _store.Add(name, period);
        }
       
    }
}
