
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество людей: ");
            int m = int.Parse(Console.ReadLine());
            Person[] people = new Person[m];
            for (int i = 0; i < m; i++)
            {
                people[i] = new Person();
                people[i].Input();
            }
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine(people[i].Name);
                Console.WriteLine(people[i].LastName);
                Console.WriteLine(people[i].Age(people[i].DateOfBirth));
                Console.WriteLine(people[i].Gender);
            }

        }
    }
}
