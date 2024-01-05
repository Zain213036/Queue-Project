using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QM_Part_3_
{
    internal class CashierClass
    {
        private int x = 10000;
        public static string getNumberInQueue = "";
        public static Queue<string> cashierQueue;
        public CashierClass()
        {
            x = 10000;
            cashierQueue = new Queue<string>();
        }
        public string CashierGeneratedNumber(string number)
        {
            x++;
            number = number + x.ToString();
            return number;
        }
    }
}
