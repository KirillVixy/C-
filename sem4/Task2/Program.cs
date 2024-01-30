int[] CreateRandomArray(int size)
{
    int max = 999;
    int min = 100;
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{  
    for (int i = 0; i < array.Length; i++)
    {  
        System.Console.Write(array[i] + " ");
        
    }
    Console.Write("Четных чисел: ");
    Console.WriteLine(CountEvenItems(array));

}

int CountEvenItems(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
                count++;
        }
    }
    return count;
}
PrintArray(CreateRandomArray(10));