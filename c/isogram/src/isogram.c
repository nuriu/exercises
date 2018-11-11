#include "isogram.h"

bool is_isogram(const char phrase[])
{
    if (!phrase)
    {
        return false;
    }

    int i = 0, j = 0;

    while(phrase[i] != '\0')
    {
        j = i + 1;

        while(phrase[j] != '\0')
        {
            if (phrase[i] != ' ' && phrase[i] != '-' && tolower(phrase[i]) == tolower(phrase[j]))
            {
                return false;
            }

            ++j;
        }

        ++i;
    }

    return true;
}
