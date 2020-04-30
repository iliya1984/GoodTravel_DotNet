using System;
using GT.Entities.Interfaces;

namespace GT.Entities.Exceptions
{
    public class InvalidEntityException: Exception
    {
        private const string ErrorMessagePrefixTempate = "Entity validation error. Entity name: {0}. {1}";

        public InvalidEntityException(IEntity entity, string message) 
            : base(string.Format(ErrorMessagePrefixTempate, entity.EntityName, message))
        {
            
        }
    }
}