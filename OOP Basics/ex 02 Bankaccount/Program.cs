using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_02_Bankaccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankaccount acc1 = new Bankaccount();
            acc1.ID = 1;
            acc1.Balance = 3000;
            Console.WriteLine(acc1);
            Bankaccount acc2 = new Bankaccount();
            acc2.ID = 2;
            acc2.Balance = 3056;

            Bankaccount acc3 = new Bankaccount(5,3560);
            Console.WriteLine(acc3);
        }
    }
}
