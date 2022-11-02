using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    public class Menu
    {
        public static string Menu1()
        {
            Console.WriteLine("Choose one of the action.");
            Console.WriteLine("1.Show all values of Array.");
            Console.WriteLine("2.Show value of Array by index.");
            Console.WriteLine("3.REmove value from Array.");
            Console.WriteLine("4.Show the length of Array.");
            string ans = Console.ReadLine();
            return ans;
        }

        public static bool Continue()
        {
            bool cont =true;
            Console.WriteLine("Do you want to continue?");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
            string ans = Console.ReadLine();

            if (ans  == "1")
            {
                cont = true;
            }
            else if (ans == "2")
            {
                cont = false;
            }
            return cont;
               
        }
    }
}
