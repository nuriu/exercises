#include "hamming.h"

#include <string.h>

// calculates hamming distance between two dna strands
int compute(const char* first_strand, const char* second_strand)
{
    int distance = 0;

    if (first_strand == NULL || second_strand == NULL)
        return -1;

    if (strlen(first_strand) != strlen(second_strand))
        return -1;

    while (*first_strand && *second_strand)
    {
        if (*first_strand++ != *second_strand++)
            ++distance;
    }

    return distance;
}
