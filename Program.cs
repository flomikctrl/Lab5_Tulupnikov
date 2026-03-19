using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Задание 1: Класс Товар ===\n");
        
        
        Product product1 = new Product();
        Product product2 = new Product("Ноутбук", 75000.50m, true); 
        
        // Вывод информации о товарах
        Console.WriteLine("Информация о первом товаре:");
        product1.ShowInfo();
        
        Console.WriteLine("Информация о втором товаре:");
        product2.ShowInfo();
        
        Console.WriteLine("\n=== Задание 2: Класс Топливный бак ===\n");
        
        FuelTank tank = new FuelTank("TNK-001");
        tank.Refuel(50); 
        tank.Consume(20); 
        tank.ShowLevel(); 
        
        Console.WriteLine("\n=== Задание 3: Класс Лифт ===\n");
        
        
        Elevator elevator = new Elevator("OTIS-2000", 15);
        elevator.ShowCurrentFloor();
        elevator.MoveUp(10);
        elevator.Reset();

        Console.WriteLine("\n=== Задание 4: Класс Лототрон ===\n");

        LotteryBall lottery1 = new LotteryBall(); // максимум 60
        LotteryBall lottery2 = new LotteryBall(100); // максимум 100
        
        Console.WriteLine("Лототрон 1 (макс 60):");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"  Число {i + 1}: {lottery1.Draw()}");
        }
        
        Console.WriteLine("\nЛототрон 2 (макс 100):");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"  Число {i + 1}: {lottery2.Draw()}");
        }
        
        
        
        Console.WriteLine("\nПрограмма завершена. Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}