using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_9._6_Task_2
{
    class NumberReader
    {
        public delegate void NumberEnteredDelegate(int number, string[] arr);
        public event NumberEnteredDelegate NumberEnteredEvent;
        public void Read(string[] arr)
        {
            Console.WriteLine();
            Console.WriteLine("Value needed - either 1 or 2.");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new WrongNumberException("Incorrect number");//My own Exception

            NumberEntered(number, arr);
        }
        protected virtual void NumberEntered(int number, string[] arr)
        {
            NumberEnteredEvent?.Invoke(number, arr);
        }
    }
}
