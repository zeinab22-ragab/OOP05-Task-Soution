using OOP05.InterFace;

namespace OOP05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOrderProcessor Online = new OnlineOrderProcessor();
            decimal onlineO = 50m;
            Console.WriteLine(onlineO);

            IOrderProcessor instore = new InStoreOrderProcessor();
            decimal inStore = 50m;
            Console.WriteLine(inStore);


            Console.WriteLine("Enter Order ID :");
            int orderId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer Name :");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter Order Amount :");
            decimal orderAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Order Type Online or InStore :");
            string orderType = Console.ReadLine();

            IOrderProcessor orderProcessor;

           
            if (orderType=="online")  
                orderProcessor = new OnlineOrderProcessor();
            else if (orderType=="InStore")
                orderProcessor = new InStoreOrderProcessor();
            else              
                return;
            

            
            Order order = new Order(orderId, customerName, orderAmount, orderProcessor);
            order.Process();


        }
    }
}
