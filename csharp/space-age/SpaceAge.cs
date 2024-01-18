using System;
using System.Collections.Generic;

public class SpaceAge
{
    private readonly Dictionary<string, double> _orbitalPeriods;
    private readonly long _seconds;

    public SpaceAge(long seconds)
    {
        _seconds = seconds;
        _orbitalPeriods = new Dictionary<string, double> { { "Earth", 31557600 } };
        _orbitalPeriods.Add("Mercury", _orbitalPeriods["Earth"] * 0.2408467);
        _orbitalPeriods.Add("Venus", _orbitalPeriods["Earth"] * 0.61519726);
        _orbitalPeriods.Add("Mars", _orbitalPeriods["Earth"] * 1.8808158);
        _orbitalPeriods.Add("Jupiter", _orbitalPeriods["Earth"] * 11.862615);
        _orbitalPeriods.Add("Saturn", _orbitalPeriods["Earth"] * 29.447498);
        _orbitalPeriods.Add("Uranus", _orbitalPeriods["Earth"] * 84.016846);
        _orbitalPeriods.Add("Neptune", _orbitalPeriods["Earth"] * 164.79132);
    }

    public double OnEarth() => _seconds / _orbitalPeriods["Earth"];
    public double OnMercury() => _seconds / _orbitalPeriods["Mercury"];
    public double OnVenus() => _seconds / _orbitalPeriods["Venus"];
    public double OnMars() => _seconds / _orbitalPeriods["Mars"];
    public double OnJupiter() => _seconds / _orbitalPeriods["Jupiter"];
    public double OnSaturn() => _seconds / _orbitalPeriods["Saturn"];
    public double OnUranus() => _seconds / _orbitalPeriods["Uranus"];
    public double OnNeptune() => _seconds / _orbitalPeriods["Neptune"];
}
