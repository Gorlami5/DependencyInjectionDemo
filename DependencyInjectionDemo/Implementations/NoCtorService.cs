using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Implementations
{
    public class NoCtorService
    {
        private readonly NoCtorClass _inject;
        public NoCtorService(NoCtorClass c)
        {
            _inject = c;
        }

        public void prinlt() => _inject.Print();
    }
}
