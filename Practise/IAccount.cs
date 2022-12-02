using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    interface IAccount
    {
        public bool PasswordChechker(string pasword);

        public string  ShowInfo();
    }
}
