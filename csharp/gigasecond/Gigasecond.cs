using System;

public static class Gigasecond
{
    private const double _gigasecond = 1e9;

    public static DateTime Add(DateTime birthDate) => birthDate.AddSeconds(_gigasecond);
}
