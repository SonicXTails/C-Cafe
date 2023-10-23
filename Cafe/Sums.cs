using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    internal class Sums
    {
        static private void Sum(int Cost, string Order)
        {
            var Sum = 0;
            var Orders = "Вы ничего не заказали";

            Sum += Cost;
            Orders += Order;

            MenuOrder.MainMenu(Sum, Order);
        }
    }
}
