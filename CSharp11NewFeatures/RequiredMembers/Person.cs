using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequiredMembers
{
    public class Person
    {
        public required string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
