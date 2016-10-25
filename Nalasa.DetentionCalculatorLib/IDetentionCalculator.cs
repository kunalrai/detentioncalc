using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nalasa.DetentionCalculatorLib
{
    public interface IDetentionCalculator
    {
        int CalculateDetention(List<OffenceType>,DetentionRule rule,DetentionType det_type);
        void AddRule();
        void AddOffenceType();
    }
}
