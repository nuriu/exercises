#include "space_age.h"

namespace space_age
{
    long long space_age::seconds() const
    {
        return _seconds;
    }

    double space_age::on_earth() const
    {
        return _seconds / EARTH;
    }

    double space_age::on_mercury() const
    {
        return _seconds / MERCURY;
    }

    double space_age::on_venus() const
    {
        return _seconds / VENUS;
    }

    double space_age::on_mars() const
    {
        return _seconds / MARS;
    }

    double space_age::on_jupiter() const
    {
        return _seconds / JUPITER;
    }

    double space_age::on_saturn() const
    {
        return _seconds / SATURN;
    }

    double space_age::on_uranus() const
    {
        return _seconds / URANUS;
    }

    double space_age::on_neptune() const
    {
        return _seconds / NEPTUNE;
    }

} // namespace space_age
