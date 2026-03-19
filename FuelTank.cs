using System;

public class FuelTank
{
    public string TankId;
    private double CurrentFuel;
    
    public FuelTank(string tankId)
    {
        this.TankId = tankId;
        this.CurrentFuel = 0;
    }
    
    public void Refuel(double amount)
    {
        if (amount > 0)
        {
            this.CurrentFuel += amount;
            Console.WriteLine($"Бак {this.TankId} заправлен на {amount} л. Текущий уровень: {this.CurrentFuel} л.");
        }
        else
        {
            Console.WriteLine("Ошибка: количество топлива должно быть положительным");
        }
    }
    
    public void Consume(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Ошибка: количество топлива должно быть положительным");
            return;
        }
        
        if (this.CurrentFuel >= amount)
        {
            this.CurrentFuel -= amount;
            Console.WriteLine($"Потрачено {amount} л. Остаток: {this.CurrentFuel} л.");
        }
        else
        {
            Console.WriteLine($"Ошибка: недостаточно топлива. Доступно: {this.CurrentFuel} л., запрошено: {amount} л.");
        }
    }
    

    public void ShowLevel()
    {
        Console.WriteLine($"Бак {this.TankId}: текущий уровень топлива {this.CurrentFuel} л.");
    }
}