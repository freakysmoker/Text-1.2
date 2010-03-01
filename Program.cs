using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program : Info
    {
        static void Main(string[] args)
        {
              
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("               Programmed by Fred Vasquez       Version 1.2");
            Console.WriteLine("                    f_vasquez1@hotmail.com\n");
            Console.Write("Enter your warrior's name: ");//input player name
            name = Console.ReadLine();
            Console.Clear();
            cit.Shang();//player spawns in Shang Gates
        }
    }
}
