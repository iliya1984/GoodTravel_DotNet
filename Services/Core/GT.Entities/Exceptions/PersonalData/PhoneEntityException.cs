using GT.Entities.Enums;
using GT.Entities.Interfaces;

namespace GT.Entities.Exceptions.PersonalData
{
    public class PhoneEntityException : DetailedEntityException<EPersonalData.PhoneEntityErrorCode>
    {
        public PhoneEntityException(IEntity entity, EPersonalData.PhoneEntityErrorCode code, string message = "") 
            : base(entity, code, string.Empty)
        {

        }
    }
}