using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCommandExample
{
    public class Broker
    {
        private List<IOrder> orderList = new List<IOrder>();

        public void takeOrder(IOrder order)
        {
            orderList.Add(order);
        }

        public void placeOrders()
        {

            foreach(IOrder order in orderList)
            {
                order.execute();
            }

            orderList.Clear();
        }
    }
}
