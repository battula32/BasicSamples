using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorOverloading
{
    public struct MyCustomInt: IEnumerable<Object>, IComparable<Object>
    {
        #region IEnumerable<object> Members

        IEnumerator<object> IEnumerable<object>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IComparable<object> Members

        int IComparable<object>.CompareTo(object other)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
