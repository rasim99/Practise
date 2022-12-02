using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Practise
{
    class User : IAccount
    {
        

        public   bool PasswordChechker (string password)
        {
            var input = password;
            

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniChars = new Regex(@".{8}");
            var hasLowerChar = new Regex(@"[a-z]+");
           

            if (!hasLowerChar.IsMatch(input))
            {
                
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
               
                return false;
            }
            else if (!hasMiniChars.IsMatch(input))
            {
                
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                
                return false;
            }

          
            else
            {
                return true;
            }
        }

        public string  ShowInfo()
        {
            string FullName="Lorem Ipsumlu";
            string Email="doler@ips.lor";
           
            return $"{FullName} {Email}";
            
        }
    }
}
