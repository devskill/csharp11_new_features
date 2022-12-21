using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAttributes
{
    internal class Implementation
    {
        [OldAttribute(typeof(string))]
        public string Method() => default;


        [NewAttribute<string>()]
        public string Method2() => default;
    }

    #region Not Allowed

    /*
    public class GenericType<T>
    {
        [NewAttribute<T>()] // Not allowed! generic attributes must be fully constructed types.
        public string Method() => default;
    }
    */

    //Use alternatives
    /*
    object for dynamic.
    string instead of string?.
    ValueTuple<int, int> instead of(int X, int Y).
    */


    #endregion
}
