using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckEquality
{
    class WeightComparer : IComparer<Ducks>

    {
        public int Compare(Ducks x, Ducks y)
        {
            return x.WeightInGrams.CompareTo(y.WeightInGrams);
        }
    }
}
