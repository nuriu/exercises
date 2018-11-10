#ifndef GIGASECOND_H
#define GIGASECOND_H

#define EXERCISM_RUN_ALL_TESTS

#include "boost/date_time/date.hpp"
#include "boost/date_time/posix_time/posix_time.hpp"

namespace gigasecond
{
    const int gigasecond = 1000000000;

    boost::posix_time::ptime advance(boost::posix_time::ptime time)
    {
        return time + boost::posix_time::seconds(gigasecond);
    }
} // gigasecond

#endif //GIGASECOND_H
