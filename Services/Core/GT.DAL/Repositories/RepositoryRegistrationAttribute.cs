using System;

namespace GT.DAL.Repositories
{
    public class RepositoryRegistrationAttribute : Attribute
    {
        public Type RegisterAsType { get; private set; }

        public RepositoryRegistrationAttribute(Type registerAsType)
        {
            RegisterAsType = registerAsType;
        }
    }
}