using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Person[] people = new Person[number];

            for(int i=0;i<number;i++)
            {
                Console.WriteLine($"Please enter person [{i + 1}] name:");
                string name = Console.ReadLine();

                Console.WriteLine($"Please enter person [{i + 1}] family:");
                string family = Console.ReadLine();


                Console.WriteLine($"Please enter person [{i + 1}] id:");
                string id = Console.ReadLine();

                Console.WriteLine($"Please enter person [{i + 1}] website:");
                string website = Console.ReadLine();

                Person p = new Person(name, family, id, website);
                people[i] = p;

            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***************************************************");
            Console.ResetColor();
             
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach(Person person in people)
            {
                Console.WriteLine($"Name: {person.name}  Family: {person.family}  Id: {person.id}  Website: {person.website}");
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
