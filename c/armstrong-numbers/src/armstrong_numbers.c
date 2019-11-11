#include "armstrong_numbers.h"

#include "math.h"

int get_digit_count(int number)
{
    int count = 0;

    while (number != 0)
    {
        number /= 10;
        count++;
    }

    return count;
}

int is_armstrong_number(int candidate)
{
    int n = get_digit_count(candidate);
    int tempCandidate = candidate;
    int result = 0;

    while (tempCandidate != 0)
    {
        result += pow(tempCandidate % 10, n);
        tempCandidate /= 10;
    }

    return result == candidate;
}
