

int Main(int n)
{
    int[] array = {1, 2, 5, 0, 10, 34};

    if(n < 0)
    {
        return 0;
    }
    else
    {
        Console.Write(array[n] + " ");
        return Main(n - 1);
    }
}
Main(5);
