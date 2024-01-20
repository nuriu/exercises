using System;

public static class AssemblyLine
{
    private static readonly int _carPerHourAtLowestSpeed = 221;


    public static double SuccessRate(int speed)
    {
        return speed switch
        {
            0 => 0.0,
            > 0 and < 5 => 1.0,
            > 4 and < 9 => 0.9,
            9 => 0.8,
            10 => 0.77,
            _ => -1,
        };
    }

    public static double ProductionRatePerHour(int speed) => _carPerHourAtLowestSpeed * speed * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)(_carPerHourAtLowestSpeed * speed * SuccessRate(speed) / 60);
}
