using System;

public class Product
{
    public string Name;
    public decimal Price;
    public bool IsInStock;
    
    public Product()
    {
        Name = "Неизвестный товар";
        Price = 0;
        IsInStock = false;
    }
    
    public Product(string name, decimal price, bool isInStock)
    {
        Name = name;
        Price = price;
        IsInStock = isInStock;
    }
    

    public void ShowInfo()
    {
        Console.WriteLine($"Товар: {Name}");
        Console.WriteLine($"Цена: {Price} руб.");
        Console.WriteLine($"Наличие: {(IsInStock ? "Есть в наличии" : "Нет в наличии")}");
        Console.WriteLine();
    }
}