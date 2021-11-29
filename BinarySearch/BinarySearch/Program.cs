
using MergeSort;

bool BinarySearch(int[] numbers, int num)
{
    if(numbers.Length == 0)
        return false;

    int mid = numbers.Length / 2;
    if (numbers[mid] == num)
        return true;
    else if (numbers[mid] > num)
        return BinarySearch(numbers.Take(mid).ToArray(), num);
    else
        return BinarySearch(numbers.Skip(mid+1).ToArray(), num);
}

int[] numbers = { 6, 33, 2, 8, 14, 22, 43, 7, 9, 10 };
numbers = MergeSortAlgorithm.MergeSort(numbers);
int searchNum;
searchNum = int.Parse(Console.ReadLine());
if (BinarySearch(numbers, searchNum))
{
    Console.WriteLine("Found");
    return;
}
Console.WriteLine("Not Found");
return;