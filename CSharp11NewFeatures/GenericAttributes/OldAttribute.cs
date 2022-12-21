using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAttributes
{
    public class OldAttribute : Attribute
    {
        public OldAttribute(Type t) => ParamType = t;

        public Type ParamType { get; }
    }
}
