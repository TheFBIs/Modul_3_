using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_05_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                Person p = new Person(input[0], int.Parse(input[1]));
                people.Add(p);
            }
            foreach (var item in people.Where(x => x.Age > 30).OrderBy(y => y.Name))
            {
                Console.WriteLine(item);
            }
        }
    }
}
