using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    internal class StockCommodity:Commodities
    {
        public double StockPrice { get; set; }

        public StockCommodity(int commodityId, string name, double stockPrice) : base(commodityId, name)
        {
            StockPrice = stockPrice;
        }
        public override double ComputePrice()
        {
            return StockPrice;
        }
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Retail Price: {StockPrice}");
        }
    }
}
