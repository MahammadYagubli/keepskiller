using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Dog : Animals, IAnimal
    {
        
        public override void Speak( )
        {
            Console.WriteLine("WOW WOW  WOW");
        }
    }
}
