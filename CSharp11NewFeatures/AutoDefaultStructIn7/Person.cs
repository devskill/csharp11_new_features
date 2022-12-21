using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDefaultStructIn7
{
    public struct Person
    {
        public string Name { get; set; }
        public double Age { get; set; }

        public Person()
        {
            Age = 5;
        }
    }
}
