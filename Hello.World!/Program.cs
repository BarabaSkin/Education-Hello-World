using System;

namespace Hello.World_
{
    class Program
    {
        private static string TryWritenValue(string Val)
        {
            Val = Console.ReadLine();            
            return Val;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Hello World! \nWrite'Esc' to stop programm");
            bool y = true;
            while (y)
            {
                string t= Console.ReadLine();               
                if (t == "Esc")
                {
                    Console.WriteLine("The end of a programm");
                    y = false;
                }
                else if (t == "esc")
                {
                    Console.WriteLine("The end of a programm");
                    y = false;
                }
                else
                {
                    Console.WriteLine("You did a mistake");
                    y = true;
                }
            }


        }
    }
}
