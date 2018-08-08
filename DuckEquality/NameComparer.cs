using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckEquality
{
    class NameComparer : IComparer<Ducks>
    {
        public int Compare (Ducks x, Ducks y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
