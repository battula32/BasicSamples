using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace IListInheritance
{
    public class CustomList<T, U> where T : IList<U>
    {
        public T t;
        public CustomList(T _t)
        {
            this.t = _t;
        }

        /// <summary>
        /// This item will be added only if the list doesn't contains the item
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>true if Add succeeds</returns>
        public bool AddUnique(U item)
        {
            if (!t.Contains(item))
            {
                t.Add(item);
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Removes the same items.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>The removed items count</returns>
        public int RemoveSameItems(U item)
        {
            int origionalCount = t.Count;

            var itms = t.Where(x => !x.Equals(item));
            var newItms = new U[itms.Count()];
            itms.ToList().CopyTo(newItms);
            t.Clear();
            foreach (U u in newItms)
            {
                t.Add(u);
            }

            ////U[] newLst = new U[t.Count];
            ////t.ToList().CopyTo(newLst);
            ////var itms = newLst.Where(x=>!x.Equals(item));
            ////t.Clear();
            ////foreach (U u in itms)
            ////{
            ////    t.Add(u);
            ////}
            
            ////IList<U> newList = new List<U>();
            ////foreach (U u in t)
            ////{
            ////    if (!u.Equals(item))
            ////    {
            ////        newList.Add(u);
            ////    }
            ////}

            ////t.Clear();
            ////foreach (U u in newList)
            ////{
            ////    t.Add(u);
            ////}

            return origionalCount - t.Count;
        }
    }
}
