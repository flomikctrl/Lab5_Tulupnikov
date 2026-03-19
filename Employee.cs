using System;

public class Employee
{
    public int SkillLevel;
    public int Energy;
    
    public Employee(int skillLevel, int energy)
    {
        SkillLevel = skillLevel;
        Energy = energy;
    }
    
    public void Work()
    {
        Console.WriteLine($"Сотрудник с уровнем навыка {SkillLevel} и энергией {Energy} выполняет задачу");
        
        if (Energy > 0)
        {
            Energy--;
            Console.WriteLine($"Энергия уменьшена до {Energy}");
        }
        else
        {
            Console.WriteLine("Внимание: у сотрудника закончилась энергия!");
        }
    }
    
    public void ShowInfo()
    {
        Console.WriteLine($"Сотрудник: навык {SkillLevel}, энергия {Energy}");
    }
}