using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace first

{
    internal class Person
    {
        public string LastName { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        private char gender;
        public char Gender
        {
            get { return gender; }
            set { if (value == 'm' || value == 'f' || value == 'M' || value == 'F' ) gender = value; }
        }
        public Person() 
        { 

        }

        public override string ToString()
        {
            return Name + " " + LastName + " " + DateOfBirth + " " + gender;
        }
        public void Input()
        {
            Console.WriteLine("Введите имя: ");
            Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            LastName = Console.ReadLine();
            Console.WriteLine("Введите дату рождения в формате год-месяц-день: ");
            DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Введите пол f/m: ");
            gender = char.Parse(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("Имя:"+ Name+ " Фамилия:" +LastName+ " Возраст:" +Age(DateOfBirth)+ " Пол:" +gender);
        }
        public int Age(DateTime BDay)
        {
            int age = DateTime.Now.Year - BDay.Year;
            if (DateTime.Now.Day < BDay.Day)
            {
                if (DateTime.Now.Month < BDay.Month)
                {
                    age--;
                }
            }
            return age;
        }
    }
}
    
