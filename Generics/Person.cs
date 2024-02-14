using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics;
public abstract record class Person(string FirstName, string LastName)
{
    public FullName Name { get;} = new FullName(FirstName, LastName);

    public override string ToString() => Name.ToString();

}

