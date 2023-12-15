using Furniture;
BookShelf bookshelf = new BookShelf(1, "Wooden Bookshelf", 150.00, 5);
Console.WriteLine("Bookshelf Information:");
bookshelf.Info();


Chair chair = new Chair(2, "Comfortable Chair", 80.00, "Leather");
Console.WriteLine("Chair Information:");
chair.Info();