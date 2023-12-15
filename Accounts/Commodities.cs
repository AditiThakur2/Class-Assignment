using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    internal class Commodities
    {
        public int CommodityId { get; set; }
        public string Name { get; set; }

        public Commodities(int commodityId, string name) 
        {
            CommodityId = commodityId;
            Name = name;
        }

        public virtual double ComputePrice()
        {
            return 0;
        }
        public virtual void Info()
        {
            Console.WriteLine($"Commodity ID: {CommodityId}");
            Console.WriteLine($"Name: {Name}");
        }
    }
}
