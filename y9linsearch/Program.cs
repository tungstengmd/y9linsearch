int[] ints = [1, 2, 3, 4, 5];
Console.Write("Enter search key: ");
var searchKey = Convert.ToInt32(Console.ReadLine());
bool found = false;
for (int index = 0; index < ints.Length; index++)
{
    if (searchKey == ints[index])
    {
        found = true;
        Console.WriteLine("Found!");
    }
    if (!found)
    {
        Console.WriteLine("Not found. :(");
    }
}