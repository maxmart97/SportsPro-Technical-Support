using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SportsProBLLClassLibrary.Miscellaneous_Classes
{
    public static class Format
    {
        public static string PhoneNumber(string phoneNumber)
        {
            Regex regexPhoneNumberNoSymb = new Regex(@"^[0-9]{10}$");
            Regex regexPhoneNumberParenth = new Regex(@"^\([0-9]{3}\) [0-9]{3}-[0-9]{4}$");
            Regex regexPhoneNumberDashes = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{4}$");

            string formattedPhoneNumber = "";

            if (regexPhoneNumberNoSymb.IsMatch(phoneNumber))
            {
                formattedPhoneNumber = string.Format("({0}) {1}-{2}",
                    phoneNumber.Substring(0, 3), phoneNumber.Substring(3, 3),
                    phoneNumber.Substring(6, 4));
            }
            else if (regexPhoneNumberParenth.IsMatch(phoneNumber))
            {
                return phoneNumber;
            }
            else if (regexPhoneNumberDashes.IsMatch(phoneNumber))
            {
                formattedPhoneNumber = string.Format("({0}) {1}-{2}",
                    phoneNumber.Substring(0, 3), phoneNumber.Substring(4, 3),
                    phoneNumber.Substring(8, 4));
            }

            return formattedPhoneNumber;
        }
    }
}
