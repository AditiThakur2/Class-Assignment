using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    internal class Chair:FurnitureItem
    {
        public string Material { get; set; }

        public Chair(int itemId, string name, double price, string material):base(itemId, name, price)
        {
            Material = material;
        }

        // Override the DisplayInfo method to include chair-specific information
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Material: {Material}");
        }
    }
}
