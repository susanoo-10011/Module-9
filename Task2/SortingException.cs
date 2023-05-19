using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class SortingException : Exception
    {
        public SortingException(string message) : base(message)
        {
        }
    }
}
