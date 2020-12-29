using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void GetNameAndAge()
        {
            Console.WriteLine("the person has name: {0} and age: {1}", Name, Age);

        }

    }
}
