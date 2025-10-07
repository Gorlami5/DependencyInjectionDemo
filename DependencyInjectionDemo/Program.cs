// See https://aka.ms/new-console-template for more information
using DependencyInjectionDemo.Containers;
using DependencyInjectionDemo.Implementations;
using DependencyInjectionDemo.Interfaces;
using System.ComponentModel;

var containerObject = new MiniContainer();


#region One class executes codes

/// To register a concrete class within the container, you can use a registration method that accepts only one generic type parameter.
/// You may use a class for dependency injection without adding it to the container, but the framework will then assign the default lifetime automatically.
containerObject.Register<NoCtorClass>();
var resolvedObject2 = containerObject.Resolve<NoCtorService>();
resolvedObject2.prinlt();
#endregion
#region Default container using
///An example was created to show the usage of the UserService class (created as a representation) with different lifetimes in a scenario requiring multiple injections
///Although we know that the default lifetime is Transient, the Lifetime signature explicitly includes Transient.
containerObject.Register<ILogger,LoggerService>(Lifetime.Singleton);
containerObject.Register<IUserRepository, UserRepository>(Lifetime.Transient);
containerObject.Register(typeof(IRepository<>), new Registration(typeof(RepositoryBase<>), Lifetime.Singleton));

var resolvedObject = containerObject.Resolve<UserService>();
resolvedObject.UseCustomRepo();
resolvedObject.UserCreate();
#endregion

#region Generic class container using
///Generic classes were configured to be added to the container by using their constructor parameters rather than their generic type parameters.
///The Repository pattern (used here only as a generic placeholder example) has also been registered within the container."
var resolvedObjectForGenerics = containerObject.Resolve<UserService>();
resolvedObjectForGenerics.UseRepo("Repository pattern base process implemented!");
#endregion





