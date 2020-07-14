using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Refrigerator fridge;
            fridge = new Refrigerator();
            fridge.SetProductData(1234, "h65r", "Samsung", 6527, "Double door", "50kg", "black");
            fridge.Display();
        }
    }
}

    