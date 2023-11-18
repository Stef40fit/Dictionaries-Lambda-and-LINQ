string[] words = Console.ReadLine().Split(" ");
Dictionary <string, int> wordCount = new();

foreach (string word in words)
{
    string caseInsesitivWord = word.ToLower();
    if (wordCount.ContainsKey(caseInsesitivWord))
    {
        wordCount[caseInsesitivWord] += 1;
    }
    else
    {
        wordCount.Add(caseInsesitivWord, 1);
    }

}
foreach(KeyValuePair<string, int> pair in wordCount)
{
    if(pair.Value % 2 != 0)
    {
        Console.Write($"{pair.Key} ");
    }
}