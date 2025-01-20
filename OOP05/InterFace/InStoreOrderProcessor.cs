using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.InterFace
{
    public class InStoreOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount - (orderAmount * 0.5m);
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Processes orders placed in physical stores");
        }
    }
}
