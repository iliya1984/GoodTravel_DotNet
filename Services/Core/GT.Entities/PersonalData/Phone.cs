using System;
using System.Text.RegularExpressions;
using GT.Entities.Entities;
using GT.Entities.Enums;
using GT.Entities.Exceptions.PersonalData;

namespace GT.Entities.PersonalData
{
    public class Phone : Entity
    {
        public int PhoneId { get; private set; }
        public string Number { get; private set;}
        public bool IsMobile { get; private set; }

        public Phone(int id, string number)
        {
            PhoneId = id;
            Number = number;

            ensureNumberValid(number);
        }

        private void ensureNumberValid(string number)
        {
            if(string.IsNullOrEmpty(number))
            {
                throw new PhoneEntityException(this, EPersonalData.PhoneEntityErrorCode.PhoneNumberIsNullOrEmpty);
            }
            
            var valid = 
                    Regex.IsMatch(number, "(00972|0|\\+972)[5][0-9]{8}") 
                ||  Regex.IsMatch(number, "(00970|0|\\+970)[5][0-9]{8}") 
                ||  Regex.IsMatch(number, "(05[0-9]|0[12346789])([0-9]{7})") 
                ||  Regex.IsMatch(number, "(00972|0|\\+972|0|)[2][0-9]{7}");

            
            if(false == valid)
            {
                throw new  PhoneEntityException(this, EPersonalData.PhoneEntityErrorCode.InvalidPhoneNumberFormat, $"Phone number: {number}");
            }
        }
    }
}