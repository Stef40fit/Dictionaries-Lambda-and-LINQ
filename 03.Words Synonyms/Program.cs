//int n = int.Parse(Console.ReadLine());
//var words = new Dictionary<string, List<string>>();
//for (int i = 0; i < n; i++)
//{
//    string word = Console.ReadLine();
//    string synonym = Console.ReadLine();
//    if (words.ContainsKey(word) == false)
//        words.Add(word, new List<string>());
//    words[word].Add(synonym);
//}
//foreach (var word in synonym)
//{
//    Console.WriteLine($"{words.Keys} - {string.Join(", ",words.Values)}");
//}
//foreach (var fruit in fruits)
//    Console.WriteLine($"{fruit.Key} -> {fruit.Value}");
int n = int.Parse(Console.ReadLine());
var words = new Dictionary<string, List<string>>();

for (int i = 0; i < n; i++)
{
    string word = Console.ReadLine();
    string synonym = Console.ReadLine();

    if (!words.ContainsKey(word))
        words.Add(word, new List<string>());

    words[word].Add(synonym);
}

foreach (var entry in words)
{
    string word = entry.Key;
    List<string> synonyms = entry.Value;
    Console.WriteLine($"{word} - {string.Join(", ", synonyms)}");
}