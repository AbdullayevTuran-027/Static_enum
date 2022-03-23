using System;
using System.Collections.Generic;
using System.Text;

namespace Static__enum.Models
{
    internal class Acount
    {
        public interface IAccount
        {
            bool PasswordChecker(string password);
            void ShowInfo();
        }
    }
}
