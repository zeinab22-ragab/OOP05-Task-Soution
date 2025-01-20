using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP05.InterFace;

namespace OOP05
{
    public class Order
    {

        int OrderId { get; set; }
        string CustomerName { get; set; }
        decimal OrderAmount { get; set; }
        public IOrderProcessor OrderProcessor { get; set; }

        public Order(int orderId, string? customerName, decimal orderAmount, IOrderProcessor orderProcessor)
        {
            OrderId = orderId;
            CustomerName = customerName;
            OrderAmount = orderAmount;
            OrderProcessor = orderProcessor;

        }

        public void Process()
        {
            OrderProcessor.ProcessOrder();
            decimal finalAmount = OrderProcessor.CalculateDiscount(OrderAmount);
            Console.WriteLine($"Order {OrderId} processed for {CustomerName}. Final amount after discount: ${finalAmount}");
        }
    }
    }
