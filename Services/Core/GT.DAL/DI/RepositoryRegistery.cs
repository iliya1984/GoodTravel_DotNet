using System;
using System.Linq;
using System.Reflection;
using Autofac;
using GT.DAL.Interfaces.Repositories;
using System.Collections.Generic;
using GT.DAL.Repositories;

namespace GT.DAL.DI
{
    public class RepositoryRegistery
    {
        private ContainerBuilder _builder;
        public RepositoryRegistery(ContainerBuilder builder)
        {
            _builder = builder;
        }

        public void Register()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var repositoryTypes = new List<Type>();
            foreach(var assembly in assemblies)
            {
                foreach(Type type in assembly.GetTypes().Where(t => t.IsAssignableTo<IRepository>()))
                {
                    repositoryTypes.Add(type);
                }
            }
            
            foreach(var type in repositoryTypes)
            {
                var attribute = type.GetCustomAttribute<RepositoryRegistrationAttribute>();
                if(attribute != null && attribute.RegisterAsType != null)
                {
                    _builder
                        .RegisterType(type)
                        .As(attribute.RegisterAsType);
                }
            }
        }
    }
}