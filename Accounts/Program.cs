using Accounts;

RetailCommodity retailCommodity = new RetailCommodity(1, "Electronics", 500.00);
retailCommodity.Info();
Console.WriteLine($"Computed Price: {retailCommodity.ComputePrice()}");

StockCommodity stockCommodity = new StockCommodity(2, "Raw Materials", 100.00);
stockCommodity.Info();
Console.WriteLine($"Computed Price: {stockCommodity.ComputePrice()}");


