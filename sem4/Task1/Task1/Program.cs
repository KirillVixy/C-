static void Main()
{
    while (true)
    {
        Console.Write("Введите число или 'q' для выхода: ");
        
        string input = Console.ReadLine();
        if (input == "q") 
        {
            break;
        } 
        int number = Convert.ToInt32(Console.ReadLine());
        if (int.TryParse(input, out number))
        {

      
            int sum = 0;
            while (number > 0) 
            {
                sum += number % 10;
                number /= 10; 
            }
            if (sum % 2 == 0) 
            {
                Console.WriteLine("Break");
                break;
            }
        }
        else 
        {
            Console.WriteLine("Ничего не вышло");
        }
   }
}
Main();



