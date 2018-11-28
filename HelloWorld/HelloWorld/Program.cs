using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            int newUserInput = Convert.ToInt32(userInput);
            Console.WriteLine(newUserInput + 20);
        }
    }
}
