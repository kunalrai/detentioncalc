using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nalasa.DetentionCalculatorLib
{
    public interface IDetentionCalculator
    {
        double CalculateDetention(List<OffenceType> offType, DetentionRule rule, DetentionType det_type);
         void AddDetentionRule(DetentionRule rule);
         void AddOffenceType(OffenceType offenceType);
    }
}
