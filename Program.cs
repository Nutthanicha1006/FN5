using System;

namespace FNT5
{
    class Program
    {
        static void Main(string[] args)
        {
            int IN,i;
            string IN1,IN2,M;
            Console.Write("");
            IN = int.Parse(Console.ReadLine());
            for(i = 0; i <= IN; i++)
            {
                Console.Write("Item : ");
                IN1 = Console.ReadLine();
                Console.Write("Kind : ");
                IN2 = Console.ReadLine();
            }
            Console.Write("Mode : ");
            M = Console.ReadLine();
            if(M == "ShowAll")
            {
                for (i = 0; i <= IN; i++)
                {
                    Console.WriteLine("{0}", IN1);
                    Console.WriteLine("{0}", IN2);
                }
            }
            else
            {
                Console.WriteLine("End");
            }
            Console.ReadLine();
        }
    }
}
