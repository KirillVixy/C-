void Find(int n)
{
    int m = 9;
    if(n >= m)
    {
        Find(n - 1);
        System.Console.Write(n + " ");
    }
}
Find(20);