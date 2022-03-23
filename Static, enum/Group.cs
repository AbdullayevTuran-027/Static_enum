using System;
using System.Collections.Generic;
using System.Text;

namespace Static__enum.Models
{
    internal class Group
    {
        private string _studentLimit;
        public int GroupNo { get; set; }

        public string StudentLimit
        {
            get
            {
                return _studentLimit;
            }
            set
            {
                if (_studentLimit.Length >= 5 && _studentLimit.Length <= 18)
                {
                    return;
                }
            }

           
        }
        private Student[] students;

        public bool CheckGroupNo(string GroupNo)
        
        {
            bool qrup = false;
            bool qrup1 = false;

            for (int i = 0; i < GroupNo.Length; i++)
            {
                if (GroupNo.Length > 5)
                {
                    if (char.IsSymbol(GroupNo[1]) && char.IsSymbol(GroupNo[2]))
                    {
                        qrup = true;
                    }
                    else
                    {
                        qrup = false;
                    }

                    if (char.IsNumber(GroupNo[3]) && char.IsNumber(GroupNo[4]) && char.IsNumber(GroupNo[5]))
                    {
                        qrup1 = true;
                    }
                    else
                    {
                        qrup1 = false;
                    }
                }
            }
            if (qrup == true && qrup1 == true)
            {
                return true;
            }
            return false;
        }

        

    }
}
