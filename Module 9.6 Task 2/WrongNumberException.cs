using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_9._6_Task_2
{
    public class WrongNumberException : Exception//My own Exception
    {
        public WrongNumberException()
        { }

        public WrongNumberException(string message)
            : base(message)
        { }
    }
}
