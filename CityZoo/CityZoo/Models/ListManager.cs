using CityZoo.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo.Models
{
    public class ListManager<T> : IListManager<T>
    {
        private List<T> list;

        /// <summary>
        /// Initializes a new instance of the ListManager class.
        /// </summary>
        public ListManager()
        {
            list = new List<T>();
        }

        /// <summary>
        /// Gets the total number of elements in the List
        /// </summary>
        public int Count
        {
            get { return list.Count; }
        }

        /// <summary>
        /// Adds an element to the end of the list.
        /// </summary>
        public virtual bool Add(T type)
        {
            if (type != null)
            {
                list.Add(type);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Changes list element at a specified position
        /// </summary>
        public bool ChnageAt(T type, int index)
        {
            if (type != null && IsValidIndex(index))
            {
                list[index] = type;
                return true;
            }
            return false;
        }

        // Not implemented
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes element from a list at a specified element
        /// </summary>
        public bool DeleteAt(int index)
        {
            if (IsValidIndex(index))
            {
                list.RemoveAt(index);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Gets a specified element form the list
        /// </summary>
        public T GetAt(int index)
        {
            if (IsValidIndex(index))
            {
                T item = list[index];
                return item;
            }
            return default(T); // Return default(T) which means you'll return null if T is a reference type. 
        }

        /// <summary>
        /// Checks if an index is within the list range
        /// </summary>
        public bool IsValidIndex(int index)
        {
            int numberOfElements = Count;
            if (index >= 0 && index < Count)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Converts all elements in the list to a formated string array
        /// </summary>
        public string[] ToStringArray()
        {
            int numberOfElements = Count;
            string[] output = new string[numberOfElements];
            for (int i = 0; i < numberOfElements; i++)
            {
                output[i] = list[i].ToString();
            }
            return output;
        }

        /// <summary>
        /// Converts all elements in the list to a formated string list
        /// </summary>
        public List<string> ToStringList()
        {
            int numberOfElements = Count;
            List<string> output = new List<string>();
            for (int i = 0; i < numberOfElements; i++)
            {
                output.Add(list[i].ToString());
            }
            return output;
        }

    } // end class
}
