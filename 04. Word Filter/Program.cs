string[] arrayOfStrings = Console.ReadLine().Split(" ").Where(x => x.Length %2 ==0).ToArray();



    foreach (string str in arrayOfStrings)
{
    Console.WriteLine(str);
}
