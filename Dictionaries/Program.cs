Dictionary<string, string> phoneBook = new();

phoneBook.Add("Jhon Smith", "+359 234 447 4674"); 
phoneBook.Add("Jhon Rambo", "+359 234 447 6788");

string value = phoneBook["Jhon Rambo"];
Console.WriteLine(value);
