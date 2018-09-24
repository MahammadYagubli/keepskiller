using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mahammad = new Person();
            mahammad.Age = 25;
             mahammad.Name = "Mahammad";
            Person gular = new Person();
            gular.Age = 28;
            gular.Name = "Gular";
            Person gul = new Person();
            gul.Age = 32;
            gul.Name = "gul";
            Person sevinc = new Person();
            sevinc.Age = 19;
            sevinc.Name = "sevinc";

            List<Person> people = new List<Person>();
            people.Add(mahammad);
            people.Add(gular);
            people.Add(sevinc);
            people.Add(mahammad);
            people.Add(gul);
            
            PrintAscending(people);
            PrintOccurrenceOfGivenAge(people, 19);
        }
     public  static void PrintAscending(List<Person> collection) {
            // firstly we will create new ages list to be able to sort them
            List<int> ages = new List<int>();
            List<Person> people = collection;
            // int foreach loop we wil add all ages into this ceated ages list
            foreach (Person person in people) {
                ages.Add(person.Age);
            }
            ages.Sort();
            ages = ages.Distinct().ToList();
            foreach (int age in ages) {

                foreach (Person person in people)
                {

                    if (age == person.Age)
                    {
                        if (age >= 18)
                        {
                            Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
                        }

                    }
                    
                }


            }



        }
     public static void
         PrintOccurrenceOfGivenAge(List<Person> collection, int age)
        {
            List<Person> people = collection;
            foreach (Person person in people)
            {
                if (person.Age==age) {
                    Console.WriteLine("  Collection contains person with a given age.");
                }

            }


        }


    }
}
