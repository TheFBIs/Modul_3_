using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        public  static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < br; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                Person p = new Person();
                p.name = input[0];
                p.age = int.Parse(input[1]);
                people.Add(p);
            }
            foreach (var item in people)
            {
                Console.WriteLine(item);
            }
        }
    }
}
