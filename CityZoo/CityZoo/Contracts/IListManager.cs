using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo.Contracts
{
    interface IListManager<T>
    {
        int Count { get; }

        bool Add(T type);
        bool ChnageAt(T type, int index);
        bool IsValidIndex(int index);
        void DeleteAll();
        bool DeleteAt(int index);
        T GetAt(int index);
        string[] ToStringArray();
        List<String> ToStringList();

    }
}
