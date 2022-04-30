using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_04_Family
{
    public  class Family
    {
        List<Person> semeystvo = new List<Person>();

        public List<Person> Semeystvo
        {
            get { return semeystvo; }
            set { semeystvo = value; }
        }


        public void Print()
        {
            foreach (var item in semeystvo)
            {
                Console.WriteLine($"{item.Name} e na {item.Age} ");
            }
        }
        public void SortAge()
        {
            semeystvo = semeystvo.OrderBy(x => x.Age).ToList();
        }
        public void Average()
        {
            int s = 0;
            int br = 0;
            foreach (var item in semeystvo)
            {
                s += item.Age;
                br++;
            }
            double Ave = s / br;
            Console.WriteLine(Ave);
        }


    }
}
