using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
String name = speak("Date");
            Console.WriteLine(name);
        }
        public static string speak (String input) {

            if (input.Equals("Hello"))
            {
                return "Hi!";
            }
            if (input.Equals(" 2 + 2 ")) {
                return "I\'m not calculator";
            }
            if (input.Equals("Date"))
            {
                
                String timenow = DateTime.Now.ToShortDateString();
                return timenow;
            }

            else {
                return "Not mentioned";
            }

        }
    }
}
