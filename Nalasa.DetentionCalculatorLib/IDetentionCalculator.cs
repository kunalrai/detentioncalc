using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nalasa.DetentionCalculatorLib
{
    public interface IDetentionCalculator
    {
        int CalculateDetention();
        void AddRule();
        void AddOffenceType();
    }
}
