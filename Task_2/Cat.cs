using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Cat: Animals, IAnimal { 
               public override void Speak( )
        {
            Console.WriteLine("miao miao");
        }
    }
}
