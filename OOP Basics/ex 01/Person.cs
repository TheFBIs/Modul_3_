using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_01
{
    public class Person
    {
        private string name;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is {Name} and i am {Age}");
        }

    }
}
