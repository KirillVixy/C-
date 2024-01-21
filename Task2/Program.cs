    void Where(int x, int y)
    {
        if (x > 0 && y > 0)
        {
            System.Console.WriteLine("1");
        }

        else if (x < 0 && y > 0)
        {
            System.Console.WriteLine("2");
        }
        else if (x < 0 && y < 0)
        {
            System.Console.WriteLine("3"); 
        }
        else if (x > 0 && y < 0)
        {
            System.Console.WriteLine("4"); 
        }
    }
System.Console.Write("Введите координаты точки X и Y через пробел:");
string[] coordinates = Console.ReadLine().Split(' ');
int x = Convert.ToInt32(coordinates[0]);
int y = Convert.ToInt32(coordinates[1]);
Where(x, y);
