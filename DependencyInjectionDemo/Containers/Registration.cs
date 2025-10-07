using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Containers
{
    public enum Lifetime
    {
        Transient,
        Singleton
    }
    public class Registration
    {
        public Type ImplementationType { get; }
        public Lifetime Lifetime { get; }
        public object? Instance { get; set; } 

        public Registration(Type implementationType, Lifetime lifetime)
        {
            ImplementationType = implementationType;
            Lifetime = lifetime;
        }
    }

}
