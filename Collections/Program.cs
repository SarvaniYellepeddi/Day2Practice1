using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Mobile M1 = new Mobile();

            MobileCatalog catalog = new MobileCatalog();
            catalog.Add(new Mobile(1001, "samsung", "note", 15000, "available in black and blue colors"));
            catalog.Add(new Mobile(1002, "one plus", "7pro", 45000, "available in black, red and blue colors"));

            var m = catalog.GetMobile(1002);
            m.Display();
        }
    }
}
