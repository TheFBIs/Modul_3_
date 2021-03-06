using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_04_Family
{
    class Person
    {
        private string name;
        private int age;
        public Person(string Name, int Age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }     

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public override string ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
