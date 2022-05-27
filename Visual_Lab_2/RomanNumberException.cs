using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Lab_2
{
    public class RomanNumberException : Exception
    {
        public override string Message
        {
            get
            {
                return "Ошибка: Число меньше, либо равно нулю";
            }
        }
    }
}
