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

        public ListManager()
        {
            list = new List<T>();
        }
        public int Count
        {
            get { return list.Count; }
        }

        public virtual bool Add(T type)
        {
            if (type != null)
            {
                list.Add(type);
                return true;
            }
            return false;
        }

        public bool ChnageAt(T type, int index)
        {
            if (type != null && IsValidIndex(index))
            {
                list[index] = type;
                return true;
            }
            return false;
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAt(int index)
        {
            if (IsValidIndex(index))
            {
                list.RemoveAt(index);
                return true;
            }
            return false;
        }

        public T GetAt(int index)
        {
            if (IsValidIndex(index))
            {
                T item = list[index];
                return item;
            }
            return default(T); // Return default(T) which means you'll return null if T is a reference type. 
        }

        public bool IsValidIndex(int index)
        {
            int numberOfElements = Count;
            if (index >= 0 && index < Count)
            {
                return true;
            }
            return false;
        }


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
    }
}
