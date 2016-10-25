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

        public double CalculateDetention(List<OffenceType> offtypes, DetentionRule rule, DetentionType det_typ)
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


        public DetentionCalculator()
        {
            InitDefaults();
        }

        private void InitDefaults()
        {
            InitDefaultOffenceType();
            InitDefaultRules();
        }

        private void InitDefaultRules()
        {
            List<DetentionRule> rules = new List<DetentionRule>{
                new  DetentionRule{ DetentionDiscount = 10, RuleName="Good Time"},
                new  DetentionRule{ DetentionDiscount = -10, RuleName="Bad Time"},
            };

            foreach (var rule in rules)
            {
                AddDetentionRule(rule);
            }
        }

        private void InitDefaultOffenceType()
        {
            List<OffenceType> off_types = new List<OffenceType>()
            {
                new OffenceType { OffenceName = "Homework not Done", Period = 1 },
                new OffenceType { OffenceName = "Stealing", Period = 2 },
                new OffenceType { OffenceName = "Fighting", Period = .5 },
                new OffenceType { OffenceName = "Untidyness", Period = 1 },
                new OffenceType { OffenceName = "Lying", Period = 1.5 },
                new OffenceType { OffenceName = "SchoolPropertyDamage", Period = 1 },

            };

            foreach (var offType in off_types)
            {
                AddOffenceType(offType);
            }
        }





    }
}
