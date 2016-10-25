using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nalasa.DetentionCalculatorLib
{
    public class DetentionCalculator:IDetentionCalculator
    {
        private Dictionary<string, double> _store = new Dictionary<string, double>();

        public int CalculateDetention(List<OffenceType>,DetentionRule rule,DetentionType det_type)
        {
            throw new NotImplementedException();
        }

        public void AddRule()
        {
            throw new NotImplementedException();
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
