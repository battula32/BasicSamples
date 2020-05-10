using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace TypeSafeCollections
{
    public class PersonCollection: IEnumerable
    {
        private ArrayList personsList = new ArrayList();

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>The count.</value>
        public int Count
        {
            get
            {
                return this.personsList.Count;
            }
        }

        /// <summary>
        /// Adds the specified p.
        /// </summary>
        /// <param name="p">The p.</param>
        public void Add(Person p)
        {
            this.personsList.Add(p);
        }

        /// <summary>
        /// Gets the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns>The item</returns>
        public Person Get(int index)
        {
            if (this.personsList.Count > index)
            {
                return (Person)this.personsList[index];
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Clears this instance.
        /// </summary>
        public void Clear()
        {
            this.personsList.Clear();
        }

        #region IEnumerable Members

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.personsList.GetEnumerator();
        }

        #endregion
    }
}
