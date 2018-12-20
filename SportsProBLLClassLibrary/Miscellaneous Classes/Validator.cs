using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SportsProBLLClassLibrary.Miscellaneous_Classes
{
    public static class Validator
    {
        public static bool IsNameValid(string name)
        {
            if (!string.IsNullOrWhiteSpace(name) && name.Length <= 50)
                return true;
            else
                return false;
        }

        public static bool IsAddressValid(string address)
        {
            if (!string.IsNullOrWhiteSpace(address) && address.Length <= 50)
                return true;
            else
                return false;
        }

        public static bool IsCityValid(string city)
        {
            if (!string.IsNullOrWhiteSpace(city) && city.Length <= 20)
                return true;
            else
                return false;
        }

        public static bool IsStateCodeValid(string stateCode)
        {
            if (!string.IsNullOrWhiteSpace(stateCode) && stateCode.Length == 2)
                return true;
            else
                return false;
        }

        public static bool IsPhoneValid(string phone)
        {
            Regex phoneNumber = new Regex(@"^\(?([0-9]{3})\)?[- ]?([0-9]{3})[- ]?([0-9]{4})$");

            if (phoneNumber.IsMatch(phone))
                return true;
            else
                return false;
        }
    }
}
