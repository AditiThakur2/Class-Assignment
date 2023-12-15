using TimeConversion;

TimePeriod timePeriod = new TimePeriod(3600);
Console.WriteLine($"Time in hours : {timePeriod.Hours} hours");
timePeriod.Hours = 3;
timePeriod.DisplaySeconds();