using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Julius Bacosa dotnet core 1.0");

            List<string> list = new List<string>();


            for(var i = 0 ; i<=100; i++){
                list.Add(i.ToString());
            }
            

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
