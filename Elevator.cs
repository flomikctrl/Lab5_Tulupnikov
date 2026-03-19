using System;

public class Elevator
{
    public string Model;
    public int CurrentFloor;
    public int MaxFloor;
    
    public Elevator(string model, int maxFloor)
    {
        this.Model = model;
        this.MaxFloor = maxFloor;
        this.CurrentFloor = 1; 
    }
    
    public void MoveUp(int floors)
    {
        if (floors <= 0)
        {
            Console.WriteLine("Ошибка: количество этажей должно быть положительным");
            return;
        }
        
        int newFloor = this.CurrentFloor + floors;
        
        if (newFloor <= this.MaxFloor)
        {
            this.CurrentFloor = newFloor;
            Console.WriteLine($"Лифт {this.Model} поднялся на {this.CurrentFloor} этаж");
        }
        else
        {
            this.CurrentFloor = this.MaxFloor;
            Console.WriteLine($"Лифт {this.Model} достиг максимального этажа ({this.MaxFloor})");
        }
    }
    
    public void Reset()
    {
        this.CurrentFloor = 1;
        Console.WriteLine($"Лифт {this.Model} возвращен на 1 этаж");
    }
    
    public void ShowCurrentFloor()
    {
        Console.WriteLine($"Лифт {this.Model} сейчас на {this.CurrentFloor} этаже");
    }
}