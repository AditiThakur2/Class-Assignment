using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    internal class RetailCommodity:Commodities
    {
        public double RetailPrice { get; set; }

        public RetailCommodity(int commodityId, string name, double retailPrice):base(commodityId,name)
        {
            RetailPrice = retailPrice;
        }
        public override double ComputePrice()
        {
            return RetailPrice;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Retail Price: {RetailPrice}");
        }
    }
}
