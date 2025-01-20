using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.InterFace
{
    public interface IOrderProcessor
    {
        public void ProcessOrder();
        decimal CalculateDiscount(decimal orderAmount);

    }
}
