using System;
using System.Collections.Generic;
using System.Text;

namespace Static__enum.Models
{
    internal class Uses
    {
        private string _Fullname;
        private string _Email;
        private string _PasswordChecker;
        private int _Id;
        private int _length;
        private int _password;
        private int i;

        public string Fullname
        {
            get => _Fullname;
            set { _Fullname = value; }
        }

        public object Email { get; }
        public object Id { get; private set; }

        public Uses(string Fullname)
        {
            this.Fullname = Fullname;
            this.Email = Email;
        }
        public bool PasswordChecker(string password)
        {
            bool chk1 = false;
            bool chk2 = false;
            bool chk3 = false;
            bool chk4 = false;

            for (i = 0; i < password.Length - 1; i++)
            {
                if (password.Length >= 8)
                {
                    chk1 = true;
                }
                else if (char.IsUpper(password[i]))
                {
                    chk2 = true;
                }
                else if (char.IsLower(password[i]))
                {
                    chk3 = true;
                }
                else if (char.IsNumber(password[i]))
                {
                    chk4 = true;
                }

            }

            if (chk1 == true && chk2 == true && chk3 == true && chk4 == true)
            {
                return true;
            }
            else
            { return false; }
            
            }

            
            public void Showinfo()
            {
            Console.WriteLine($"Id:{Id}");
            Console.WriteLine($"Fullname:{this.Fullname}");
            Console.WriteLine($"E-mail:{Email}");
            }
           
    
        
    }
}