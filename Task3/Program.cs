

static void Main()
{
    Console.Write("Введите число из отрезка [10, 99]: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if(number >= 10 && number <= 99)
    {
        int firstDigit = number / 10;
        int SecondDigit = number % 10;
        int maxDigit = firstDigit > SecondDigit ? firstDigit : SecondDigit;
        Console.WriteLine(maxDigit);
    }
    else 
    {
        System.Console.WriteLine("NO");
    }


}
Main();




