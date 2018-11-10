#ifndef LEAP_H
#define LEAP_H

#define EXERCISM_RUN_ALL_TESTS

namespace leap
{
    bool is_leap_year(int year)
    {
        return (year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0);
    }
} // leap

#endif
