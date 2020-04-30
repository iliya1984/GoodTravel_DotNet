using GT.Entities.Interfaces;

namespace GT.Entities.Exceptions
{
    public class DetailedEntityException<TErrorCode>: InvalidEntityException
    {
        private const string ErrorMessagePrefixTempate = "Error code: {0}. {1}";


        public TErrorCode ErrorCode {get; private set;}

        public DetailedEntityException(IEntity entity, TErrorCode code, string message) 
            : base(entity, string.Format(ErrorMessagePrefixTempate, code, message))
        {

        }
    }
}