using DependencyInjectionDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Implementations
{
    public class RepositoryBase<T> : IRepository<T>
    {
        public void Add(T item)
        {
            Console.WriteLine(item);
        }
    }
}
