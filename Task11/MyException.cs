using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_9
{
    class MyException : Exception
    {
        public MyException() : base ("Это мое исключение")
        {

        }

        public MyException(string message) : base(message)
        {

        }
    }
}
