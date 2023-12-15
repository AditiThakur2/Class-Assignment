using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    internal class BookShelf:FurnitureItem
    {
        public int NoOfShelf;

        public BookShelf(int itemId, string name, double price, int noOfShelf):base(itemId, name, price)
        {
            NoOfShelf = noOfShelf;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Number of Shelves: {NoOfShelf}");
        }
    }
}
