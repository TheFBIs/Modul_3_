using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_02_Bankaccount
{
    public class Bankaccount
    {
        private int id;
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public Bankaccount (int ID, double Balance)
        {
            this.ID = id;
            this.Balance = balance;
        }
        public Bankaccount()
        {

        }
        public override string ToString()
        {
            return $" The balance of the bank account {ID} is: {Balance}";
        }
    }
}
