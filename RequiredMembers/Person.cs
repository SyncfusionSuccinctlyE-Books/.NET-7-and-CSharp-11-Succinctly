using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequiredMembers;

public class Person
{
    public required string Firstname { get; init; }
    public required string Lastname { get; init; }
    public required int Age { get; set; }
}

