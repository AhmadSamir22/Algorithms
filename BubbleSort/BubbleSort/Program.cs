// Bubble Sort Sorting algorithm
// Complexity => Upper bound(worst case scenario) O(n^2) - Lower bound(best case scenario) Ω(n)
int[] BubbleSort(int[] numbers)
{
    for (int n = 0; n < numbers.Length; n++)
    {
        bool noSwap = true;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i + 1])
            {
                int temp = numbers[i];
                numbers[i] = numbers[i + 1];
                numbers[i + 1] = temp;
                noSwap = false;
            }
        }
        if (noSwap)
            return numbers;
    }
    return numbers;
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

numbers = BubbleSort(numbers);

for (int i = 0; i < count; i++)
{
    Console.Write(numbers[i]);
    Console.Write(' ');
}
return;