using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityZoo
{
    class Cat : Mammal
    {
        public Cat(int id) : base(id)
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
