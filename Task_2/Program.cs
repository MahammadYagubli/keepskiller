using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
       
        static void Main(string[] args)
        { 
            List<Animals> animals = new List<Animals>();
            var cats = new List<Cat>();
            var dogs = new List<Dog>();
                   Cat cat = new Cat();
                   Dog dog = new Dog();
      
            animals.Add(cat);
            animals.Add(dog);
            animals.Add(cat);
            animals.Add(dog);
            animals.Add(cat);
            animals.Add(dog);
            animals.Add(cat);
            animals.Add(dog);
            

            PrintNrInPopulation(animals,2);
        }
        public static void  PrintNrInPopulation(List<Animals> animals, int nr) {
            List<Animals> myanimal = animals;
            myanimal[nr - 1].Speak();
        }
    }
}
