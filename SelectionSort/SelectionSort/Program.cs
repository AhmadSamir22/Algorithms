int[] SelectionSort(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        int smallest = numbers[i];
        int smallestIndex = i;
        for (int j = i; j < numbers.Length; j++)
        {
            if (numbers[j] < smallest)
            {
                smallest = numbers[j];
                smallestIndex = j;
            }
        }
        int current = numbers[i];
        numbers[i] = numbers[smallestIndex];
        numbers[smallestIndex] = current;
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

numbers = SelectionSort(numbers);

for (int i = 0; i < count; i++)
{
    Console.Write(numbers[i]);
    Console.Write(' ');
}
return;
