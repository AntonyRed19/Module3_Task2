using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Helpers
{
    public class GroupByList<T> : IComparer<T>
        where T : IGroupByList
    {
        public int Compare(T x, T y)
        {
            return x.GroupBy.ToUpper().CompareTo(y.GroupBy.ToUpper());
        }
    }
}
