using System;

namespace Module_9._6_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lastNames = { "Smith", "Johnson", "Williams", "Brown", "Jones" };//Last Names 
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += SortNames;

            while (true)
            {

                try
                {
                    numberReader.Read(lastNames);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrent value entered.");
                }
                catch(WrongNumberException ex)//My own Exception
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void SortNames(int number, string[] arr)
        {
            Array.Sort<string>(arr);//Sorting A-Z

            switch (number)
            {
                case 1:
                {
                    //Console.WriteLine("Entered value is 1");
                    Console.WriteLine("Sorted A-Z:");
                    break;
                }

                case 2:
                {
                    //Console.WriteLine("Entered value is 2");
                    Console.WriteLine("Sorted Z-A:");
                    Array.Reverse(arr);//Sorting Z-A                     
                    break;
                }
            }

            foreach (string ln in arr)
            {
                Console.WriteLine(ln);
            }
        }
    }

}