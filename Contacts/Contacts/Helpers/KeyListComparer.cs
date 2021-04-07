using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Helpers
{
    public class KeyListComparer<T> : IComparer<KeyValuePair<string, List<T>>>
        where T : IGroupByList
    {
        public int Compare(KeyValuePair<string, List<T>> x, KeyValuePair<string, List<T>> y)
        {
            return x.Key.ToUpper().CompareTo(y.Key.ToUpper());
        }
    }
}
