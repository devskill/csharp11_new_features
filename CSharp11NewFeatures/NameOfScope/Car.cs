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
        [return: NotNullIfNotNull(nameof(url))]
        string? GetTopLevelDomainFromFullUrl(string? url)
        {
            throw new NotImplementedException();
        }
    }
}
