
// Linear Search Algorithm => searching naive algorithm
// Complexity => Upper bound(worst case scenario) O(n) - Lower bound(best case scenario) Ω(1)
bool LinearSearch(int[] numbers, int num)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == num)
        {
            return true;
        }
    }
    return false;
}

bool LinearSearchRecursive(int[] numbers, int num)
{
    if(numbers.Length == 0)
        return false;
    if(numbers[numbers.Length - 1] == num)
        return true;
    return LinearSearchRecursive(numbers.Take(numbers.Length - 1).ToArray(), num);
}

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int searchNum;
searchNum = int.Parse(Console.ReadLine());
if(LinearSearchRecursive(numbers, searchNum))
{
    Console.WriteLine("Found");
    return;
}
Console.WriteLine("Not Found");
return;


