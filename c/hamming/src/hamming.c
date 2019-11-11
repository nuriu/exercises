#include "hamming.h"

// calculates hamming distance between two dna strands
int compute(const char* first_strand, const char* second_strand)
{
    int distance = 0;

    while (*first_strand && *second_strand)
    {
        if (*first_strand++ != *second_strand++)
            ++distance;
    }

    return distance;
}
