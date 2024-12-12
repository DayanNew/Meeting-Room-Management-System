using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeueProjektarbeit
{
    internal class Catering
    {
        private string orderList;

        public Catering(string orderList)
        {
            OrderList = orderList;
        }

        public string OrderList { get => orderList; set => orderList = value; }

        public override string ToString()
        {
            return OrderList;
        }
    }
}
