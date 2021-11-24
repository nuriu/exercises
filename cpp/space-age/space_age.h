#if !defined(SPACE_AGE_H)
#define SPACE_AGE_H

#include <map>
#include <string>

namespace space_age
{
    const double EARTH = 31557600;
    const double MERCURY = (EARTH * 0.2408467);
    const double VENUS = (EARTH * 0.61519726);
    const double MARS = (EARTH * 1.8808158);
    const double JUPITER = (EARTH * 11.862615);
    const double SATURN = (EARTH * 29.447498);
    const double URANUS = (EARTH * 84.016846);
    const double NEPTUNE = (EARTH * 164.79132);

    class space_age
    {
    private:
        long long _seconds;

    public:
        space_age(long long seconds) : _seconds(seconds){};
        ~space_age(){};

        long long seconds() const;

        double on_earth() const;
        double on_mercury() const;
        double on_venus() const;
        double on_mars() const;
        double on_jupiter() const;
        double on_saturn() const;
        double on_uranus() const;
        double on_neptune() const;
    };
} // namespace space_age

#endif // SPACE_AGE_H
