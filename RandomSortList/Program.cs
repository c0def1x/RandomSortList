var startList = new List<int> { 1, 2, 3, 4, 5 };
var random = new Random();

List<int> RandomSortList(List<int> list)
{
    for (int i = list.Count - 1; i >= 1; i--)
    {
        int j = random.Next(i + 1);
        (list[i], list[j]) = (list[j], list[i]);
    }
    return list;
}

void PrintList(List<int> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        Console.Write(list[i] + " ");
    }
}

Console.WriteLine("Данный список:");
PrintList(startList);
var randomList = RandomSortList(startList);
Console.WriteLine("\nНовый список:");
PrintList(randomList);