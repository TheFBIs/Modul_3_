using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3_Bankaccount_addition
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankaccount acc = new Bankaccount(1, 25000);
            Console.WriteLine(acc);
            acc.Depozit(100);
            Console.WriteLine(acc);
            acc.withdraw(2000);
            Console.WriteLine(acc);
        }
    }
}
