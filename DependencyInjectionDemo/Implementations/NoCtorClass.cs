using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Implementations
{
    public class NoCtorClass
    {
        public void Print() => Console.WriteLine("There is no consturctor! Default life time is transient!");
    }
}
