using System;
using System.Collections.Generic;

public class SpaceAge {
    Dictionary<string, double> _orbitalPeriods = new Dictionary<string, double> ();
    private readonly long _seconds;

    public SpaceAge (long seconds) {
        _seconds = seconds;

        _orbitalPeriods["Earth"] = 31557600;
        _orbitalPeriods["Mercury"] = _orbitalPeriods["Earth"] * 0.2408467;
        _orbitalPeriods["Venus"] = _orbitalPeriods["Earth"] * 0.61519726;
        _orbitalPeriods["Mars"] = _orbitalPeriods["Earth"] * 1.8808158;
        _orbitalPeriods["Jupiter"] = _orbitalPeriods["Earth"] * 11.862615;
        _orbitalPeriods["Saturn"] = _orbitalPeriods["Earth"] * 29.447498;
        _orbitalPeriods["Uranus"] = _orbitalPeriods["Earth"] * 84.016846;
        _orbitalPeriods["Neptune"] = _orbitalPeriods["Earth"] * 164.79132;
    }

    public double OnEarth () {
        return _seconds / _orbitalPeriods["Earth"];
    }

    public double OnMercury () {

        return _seconds / _orbitalPeriods["Mercury"];
    }

    public double OnVenus () {

        return _seconds / _orbitalPeriods["Venus"];
    }

    public double OnMars () {

        return _seconds / _orbitalPeriods["Mars"];
    }

    public double OnJupiter () {

        return _seconds / _orbitalPeriods["Jupiter"];
    }

    public double OnSaturn () {

        return _seconds / _orbitalPeriods["Saturn"];
    }

    public double OnUranus () {

        return _seconds / _orbitalPeriods["Uranus"];
    }

    public double OnNeptune () {

        return _seconds / _orbitalPeriods["Neptune"];
    }
}
