using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameOfScope
{
    public class Car
    {
        [MyAttribute(nameof(model))]
        public void Start(string model)
        {
            throw new NotImplementedException();
        }
    }
}
