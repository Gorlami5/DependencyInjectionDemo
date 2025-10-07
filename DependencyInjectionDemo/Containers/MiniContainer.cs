using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Containers
{
    public class MiniContainer
    {
        private readonly Dictionary<Type, Registration> _registrations = new();

        public void Register(Type sType,Registration iType)
        {
            _registrations[sType] = iType;
        }

        public void Register<TClass>(Lifetime lifetime = Lifetime.Transient)
        {
            _registrations[typeof(TClass)] = new Registration(typeof(TClass), lifetime);
        }
        public void Register<TInterface, TImplementation>(Lifetime lifetime = Lifetime.Transient)
        {       
            _registrations[typeof(TInterface)] = new Registration(typeof(TImplementation), lifetime);
        }

        public T Resolve<T>()
        {
            return (T)Resolve(typeof(T));
        }

        private object Resolve(Type type)
        {
            if(type.IsGenericType && _registrations.TryGetValue(type.GetGenericTypeDefinition(), out var imp1))
            {
                var genericArgs = type.GetGenericArguments();
                var closedType = imp1.ImplementationType.MakeGenericType(genericArgs);
                return GetInstance(imp1, closedType);
            }
            if(_registrations.TryGetValue(type,out var imp2))
            {
                return GetInstance(imp2, imp2.ImplementationType);
            }

            if (!type.IsAbstract)
            {
                return CreateInstance(type);
            }

            throw new Exception("Some error occured!");

        }

        private object CreateInstance(Type type)
        {
            var ctor = type.GetConstructors().First();

            var parameters = ctor.GetParameters().Select(p => Resolve(p.ParameterType)).ToArray();

            return Activator.CreateInstance(type, parameters)!;
        }

        private object GetInstance(Registration reg, Type implementationType)
        {
            if (reg.Lifetime == Lifetime.Singleton)
            {
                if (reg.Instance == null)
                    reg.Instance = CreateInstance(implementationType);

                return reg.Instance;
            }

            return CreateInstance(implementationType);
        }
    }
}
