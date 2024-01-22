


static void Main()
{
    Console.Write("Введите натуральное число n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n < 10)
    {
        Console.WriteLine(n);
    }
    else
    {
        while (n > 0)
        {
            int Num1 = n % 10;
            n /= 10;
            if (n > 0)
            {
               Console.Write(Num1 + ",");
            }
            else
            {
                Console.WriteLine(Num1);
            }
        }
    }
}
Main();





