using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    internal class FurnitureItem
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public FurnitureItem(int itemId, string name, double price)
        {
            ItemId = itemId;
            Name = name;
            Price = price;
        }
        public virtual void Info()
        {
            Console.WriteLine($"Item ID: {ItemId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}
