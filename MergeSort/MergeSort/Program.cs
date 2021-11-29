
int[] MergeSort(int[] numbers)
{
    if(numbers.Length == 1)
        return numbers;
    int middle = numbers.Length / 2;
    int[] left = MergeSort(numbers.Take(middle).ToArray());
    int[] right = MergeSort(numbers.Skip(middle).ToArray());

    return Merge(left, right);

}
int[] Merge(int[] left,int[] right)
{
    int l = 0, r = 0, k = 0;
    int[] sortedNumbers = new int[left.Length + right.Length];
    while (k < sortedNumbers.Length)
    {
        if (l >= left.Length)
        {
            sortedNumbers[k] = right[r];
            r++;
            k++;
        }
        else if(r >= right.Length)
        {
            sortedNumbers[k] = left[l];
            l++;
            k++;
        }
        else if (left[l] < right[r])
        {
            sortedNumbers[k] = left[l];
            l++;
            k++;
        }
        else
        {
            sortedNumbers[k] = right[r];
            r++;
            k++;
        }
    }
    return sortedNumbers;

}
    int[] numbers;
    int count;

    Console.WriteLine("What is Numbers Count?");
    count = int.Parse(Console.ReadLine());
    numbers = new int[count];

    Console.WriteLine("Enter numbers separated by new line (enter): ");
    for (int i = 0; i < count; i++)
    {
        numbers[i] = int.Parse(Console.ReadLine());
    }

    numbers = MergeSort(numbers);

    for (int i = 0; i < count; i++)
    {
        Console.Write(numbers[i]);
        Console.Write(' ');
    }
    return;