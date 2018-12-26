using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SportsProBLLClassLibrary.Miscellaneous_Classes
{
    public static class CustomerValidator
    {
        public static string IsCustomerDataValid(string name, string address, string stateCode, 
            string city, string zipCode, string phoneNumber, string email)
        {
            if (IsNameValid(name))
            {
                if (IsAddressValid(address))
                {
                    if (IsCityValid(city))
                    {
                        if (IsStateCodeValid(stateCode))
                        {
                            if (IsZipCodeValid(zipCode))
                            {
                                if (IsPhoneNumberValid(phoneNumber))
                                {
                                    if (IsEmailValid(email))
                                    {
                                        return "Valid.";
                                    }
                                    else
                                    {
                                        return "Email is invalid.";
                                    }
                                }
                                else
                                {
                                    return "PhoneNumber is invalid. Use XXXXXXXXXX format.";
                                }
                            }
                            else
                            {
                                return "ZipCode is invalid. Can only be 5 digits.";
                            }
                        }
                        else
                        {
                            return "StateCode is invalid.";
                        }
                    }
                    else
                    {
                        return "City is invalid.";
                    }
                }
                else
                {
                    return "Address is invalid";
                }
            }
            else
            {
                return "Name is invalid.";
            }
        }

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

        public static bool IsZipCodeValid(string zipCode)
        {
            Regex regexZipCode = new Regex(@"^[0-9]{5}$");

            if (regexZipCode.IsMatch(zipCode))
                return true;
            else
                return false;
        }

        public static bool IsPhoneNumberValid(string phone)
        {
            Regex regexPhoneNumberNoSymb = new Regex(@"^[0-9]{10}$");
            Regex regexPhoneNumberParenth = new Regex(@"^\([0-9]{3}\) [0-9]{3}-[0-9]{4}$");
            Regex regextPhoneNumberDashes = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{4}$");

            if (regexPhoneNumberNoSymb.IsMatch(phone))
                return true;
            else if (regexPhoneNumberParenth.IsMatch(phone))
                return true;
            else if (regextPhoneNumberDashes.IsMatch(phone))
                return true;
            else
                return false;
        }

        public static bool IsEmailValid(string email)
        {
            Regex regexEmail = new Regex(@"^(?i)[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$");

            if (email.Length <= 254 && regexEmail.IsMatch(email))
                return true;
            else
                return false;
        }
    }
}
