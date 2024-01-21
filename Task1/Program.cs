
    void Main(int num)
    { 
        if (num % 7 == 0 && num % 23 == 0)
        {
            System.Console.WriteLine("да");
        }
        else
        {
            System.Console.WriteLine("нет");
        }
    }
System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Main(num);
