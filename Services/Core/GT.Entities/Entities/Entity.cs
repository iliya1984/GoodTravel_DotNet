using System;
using GT.Entities.Interfaces;

namespace GT.Entities.Entities
{
    public abstract class Entity : IEntity
    {
        public string EntityName { get; private set; }

        protected Entity()
        {
            EntityName = ensureNameValidAndSet();   
        }

        private string ensureNameValidAndSet()
        {
            var entityName = GetType().Name;

            if(entityName.Length < 3)
            {
                throw new Exception($"Error: Entity name {entityName} is too short, minimum three charachter required");
            }

            return entityName;
        }
    }
}