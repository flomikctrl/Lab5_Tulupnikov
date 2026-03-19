using System;

public class LotteryBall
{
    private int _maxNumber;
    private Random _random;
    
    public LotteryBall(int maxNumber = 60)
    {
        _maxNumber = maxNumber;
        _random = new Random();
    }
    
    // Метод для получения случайного числа
    public int Draw()
    {
        return _random.Next(1, _maxNumber + 1);
    }
}