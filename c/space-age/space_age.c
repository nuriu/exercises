#include "space_age.h"

const float orbitalPeriods[8] = {
    0.2408467f,  // MERCURY
    0.61519726f, // VENUS
    31557600.0f, // EARTH
    1.8808158f,  // MARS
    11.862615f,  // JUPITER
    29.447498f,  // SATURN
    84.016846f,  // URANUS
    164.79132f   // NEPTUNE
};

float age(planet_t planet, int64_t seconds)
{
    if (planet != EARTH)
    {
        return seconds / (orbitalPeriods[planet] * orbitalPeriods[EARTH]);
    }
    else
    {
        return seconds / orbitalPeriods[planet];
    }
}
