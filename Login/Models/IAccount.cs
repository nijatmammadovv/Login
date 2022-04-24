using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Models
{
    interface IAccount
    {
        bool PasswordChecker(string password);
        void ShowInfo();
    }
}
