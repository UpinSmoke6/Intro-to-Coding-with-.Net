Dictionary<string, string> BookList = new Dictionary<string, string>();

BookList.Add("Michael Price", "Microsoft 365");
BookList.Add("Nick Vandome", "Windows 11");
BookList.Add("Mike McGrath", "SQL");

Console.WriteLine("Popular Books...");

foreach(KeyValuePair < String, String> book in BookList)
{
    Console.WriteLine($"Key: {book.Key} Value: {book.Value} in easy steps");
}